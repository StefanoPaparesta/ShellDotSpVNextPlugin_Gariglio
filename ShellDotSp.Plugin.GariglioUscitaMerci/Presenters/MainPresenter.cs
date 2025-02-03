#region Using
using DotSpExtensions;

using NLog;

using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioCore.Util.GariglioServer.Core.Service;
using ShellDotSp.Plugin.GariglioUscitaMerci.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace ShellDotSp.Plugin.GariglioUscitaMerci.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        #region Fields

        private VDocumentoTestata _DocumentoSelezionato;
        private Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties
        public List<Anagrafica> Clienti { get; set; }
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
        public List<TipoDocumento> TipoDocumenti { get; set; }
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
            TipoDocumenti = new TipoDocumentoCollection().ToList();
            LoadDocumenti();
        }

        internal void LoadAnagrafiche(string Tipo)
        {

            string sql = "FROM Anagrafiche WHERE Tipo = @0 Order by RagioneSociale";
            Clienti = Repository.Query<Anagrafica>(sql, Tipo).ToList();

        }
        internal void LoadArticoli()
        {

            string sql = "FROM Articoli WHERE Categoria = 'VEN' Order by Descrizione";
            Articoli = Repository.Query<Articolo>(sql).ToList();

        }

        internal void LoadDocumenti()
        {
            List<string> TipoDocumenti = new List<string>();
            TipoDocumenti.Add("DDT");
            TipoDocumenti.Add("FIM");

            string sqlDocumenti = "FROM vw_DocumentiTestata WHERE (DataDocumento >= @0 AND DataDocumento <= @1) AND TipoDocumento IN(@2) Order By DataDocumento DESC";
            Documenti =
                Repository.Query<VDocumentoTestata>
                (sqlDocumenti, OrdiniDal.WithoutHH(), OrdiniAl.WithoutHH(), TipoDocumenti).ToList();

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

                        if (string.IsNullOrEmpty(Documento.Numero))
                        {

                            CounterDocDDT cDDT = new CounterDocDDT(Repository);
                            //Documento.Numero = cDDT.GetNextValue();

                        }

                        Repository.Insert(Documento);

                    }
                    else
                    {

                        Repository.Update(Documento);

                    }

                    foreach (var item in Documento.Dettaglio)
                    {

                        if (item.Id == 0)
                        {
                            item.IdTestata = Documento.Id;
                            Repository.Insert(item);
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

        internal bool VerificaLottoConf(string Lotto)
        {

            string sql = "FROM DocumentiTestate WHERE Tipo = @0 AND CicloProduzione = @1 AND Lotto = @2";

            var row = Repository.Query<DocumentoTestata>(sql, "LAV", "CONF", Lotto).SingleOrDefault();

            return row != null;

        }

        #endregion

    }
}
