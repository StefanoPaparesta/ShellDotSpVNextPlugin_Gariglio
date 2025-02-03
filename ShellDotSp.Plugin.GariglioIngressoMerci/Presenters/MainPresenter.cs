#region Using
using DevExpress.XtraReports.UI;

using DotSpExtensions;

using NLog;

using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioIngressoMerci.Interfaces;
using ShellDotSp.Plugin.GariglioIngressoMerci.Report;

using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace ShellDotSp.Plugin.GariglioIngressoMerci.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        #region Fields

        private VDocumentoTestata _DocumentoSelezionato;
        private Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties

        public List<Anagrafica> Fornitori { get; set; }
        public List<Articolo> Articoli { get; set; }

        public VDocumentoTestata DocumentoSelezionato
        {
            get { return _DocumentoSelezionato; }
            set
            {
                _DocumentoSelezionato = value;
                View.UpdateUI(Function.DocumentoSelezionato);
            }
        }
        public List<VDocumentoTestata> Documenti { get; set; }
        public DateTime OrdiniDal { get; set; }
        public DateTime OrdiniAl { get; set; }

        #endregion

        #region Ctor
        public MainPresenter(IMainView View)
            : base(View)
        {

        }
        #endregion

        #region IMainView

        protected override void CloseView(object sender, EventArgs e)
        {
        }
        protected override void ViewInitialized(object sender, EventArgs e)
        {
            LoadDocumenti();
        }

        internal void LoadAnagrafiche(string Tipo)
        {
            string sql = "FROM Anagrafiche WHERE Tipo = @0 Order by RagioneSociale";

            if (Tipo == "F")
            {
                Fornitori = Repository.Query<Anagrafica>(sql, Tipo).ToList();
            }

        }
        internal void LoadArticoli()
        {

            string sql = "FROM Articoli Order by Descrizione";
            Articoli = Repository.Query<Articolo>(sql).ToList();

        }

        internal void LoadDocumenti()
        {
            string sqlDocumenti = "FROM vw_DocumentiTestata WHERE (DataDocumento >= @0 AND DataDocumento <= @1) AND TipoDocumento = @02 Order By DataDocumento DESC";
            Documenti =
                Repository.Query<VDocumentoTestata>
                (sqlDocumenti, OrdiniDal.WithoutHH(), OrdiniAl.WithoutHH(), "BEM").ToList();

            View.UpdateUI(Function.ElencoDocumenti);
        }

        internal List<DocumentoRiga> LoadRighe(int IdTestata)
        {

            string sql = "FROM DocumentiRighe WHERE IdTestata = @0";
            return Repository.Query<DocumentoRiga>(sql, IdTestata).ToList();

        }

        internal void CancellaRigaDocumento(DocumentoRiga RigaSelezionata)
        {

            if (RigaSelezionata.Id != 0)
            {
                string sqlDelete = "DELETE FROM DocumentiRighe WHERE Id = @0";
                Repository.Execute(sqlDelete, RigaSelezionata.Id);

                string sqlDeleteMovimento = "DELETE FROM MagazzinoMovimenti WHERE CAUSALE IN (@0) AND IdDocRiga = @1";

                List<string> Causali = new List<string>();
                Causali.Add("CMG");
                Causali.Add("UMG");
                Repository.Execute(sqlDeleteMovimento, Causali, RigaSelezionata.Id);

            }

        }

        internal void ManageDocumento(DocumentoTestata Documento)
        {

            if (Documento != null)
            {

                try
                {

                    Repository.StartConversation();

                    if (Documento.Id == 0)
                    {

                        Repository.Insert(Documento);

                    }
                    else
                    {

                        Repository.Update(Documento);

                    }

                    foreach (var item in Documento.Dettaglio)
                    {

                        Logger.Info($"Id riga {item.Id}");

                        if (item.Id == 0)
                        {
                            item.IdTestata = Documento.Id;
                            Repository.Insert(item);

                            Logger.Info($"Id riga {item.Id}");

                            // Inserisco i movimenti 
                            // ToDo devo comunque verificare di non fare duplicati

                            //string sqlGetGiacenza = "FROM MagazzinoGiacenze WHERE IdArticolo = @0 AND Lotto = @1";

                            //var giac = Repository.Query<MagazzinoGiacenza>
                            //    (sqlGetGiacenza, item.IdArticolo, item.Lotto).SingleOrDefault();

                            //if (giac == null)
                            //    {

                            //    MagazzinoGiacenza newGiac = new MagazzinoGiacenza()
                            //        {
                            //        IdArticolo = item.IdArticolo,
                            //        Lotto = item.Lotto,
                            //        UM = item.Um
                            //        };

                            //    Repository.Insert(newGiac);
                            //    }


                            string causale = "CMG";

                            string sqlGetArticolo = "FROM Articoli WHERE Id = @0";
                            var localArt = Repository.Query<Articolo>(sqlGetArticolo,
                                item.IdArticolo).SingleOrDefault();

                            if (localArt != null && localArt.Categoria == "TB")
                            {
                                causale = "UMG";
                            }

                            string sqlGetMov = "FROM MagazzinoMovimenti WHERE IdDocRiga = @0 AND Causale = @1";

                            var movCarico = Repository.Query<MagazzinoMovimento>
                              (sqlGetMov, item.Id, causale).SingleOrDefault();

                            Logger.Info($"Args IdArticolo : {item.Id} Causale : {causale}");

                            if (movCarico == null)
                            {
                                Logger.Info($"movCarico NULL");

                                MagazzinoMovimento newMovCarico = new MagazzinoMovimento()
                                {
                                    IdArticolo = item.IdArticolo,
                                    CodiceMagazzino = "001",
                                    Causale = causale,
                                    IdDocRiga = item.Id,
                                    IdDocTestata = item.IdTestata,
                                    Lotto = item.Lotto,
                                    Qta = item.Qta,
                                    Ubicazione = "GEN",
                                    UM = item.Um,
                                    TsCreazione = DateTime.Now
                                };




                                Repository.Insert(newMovCarico);

                            }
                            else
                            {
                                Logger.Info($"movCarico NOT NULL");
                            }
                        }
                        else
                        {
                            //Repository.Update(item);
                        }

                    }

                    Repository.StopConversation();

                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                    Repository.AbortConversation();
                }


            }
        }

        internal List<string> StampaLabelProduzione()
        {

            List<string> Errors = new List<string>();

            try
            {


                string sql = "FROM vw_Documenti WHERE IdTestata = @0";

                var ds = Repository.Query<VDocumento>
                    (sql, DocumentoSelezionato.IdTestata).Select(x => new LabelProduzioneDTO()
                    {

                        CodiceProduzione = x.CodiceProduzione,
                        Descrizione = x.DescArticolo

                    }).ToList();

                using (RptLabelProduzione rpt =
                    new RptLabelProduzione())
                {

                    rpt.DataSource = ds;
                    rpt.ShowPreviewDialog();

                }



            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
                Logger.Error(ex.Message);
            }


            return Errors;

        }

        internal void CancellaDocumento()
        {

            string deleteRighe = "DELETE FROM DocumentiRighe WHERE IdTestata = @0";
            string deleteTestata = "DELETE FROM DocumentiTestate WHERE Id = @0";

            Repository.Execute(deleteRighe, DocumentoSelezionato.IdTestata);
            Repository.Execute(deleteTestata, DocumentoSelezionato.IdTestata);

        }

        #endregion

    }
}
