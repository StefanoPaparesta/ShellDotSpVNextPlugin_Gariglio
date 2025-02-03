#region Using
using DevExpress.XtraReports.UI;

using DotSpExtensions;

using Newtonsoft.Json;

using NLog;

using NPoco;

using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioTraccia.Helpers;
using ShellDotSp.Plugin.GariglioTraccia.Interfaces;
using ShellDotSp.Plugin.GariglioTraccia.Report;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        #region Fields

        public Dictionary<string, string> Pagine { get; set; }
            = new Dictionary<string, string>();
        public string PaginaCorrente { get; set; }

        private Logger Logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Ctor
        public MainPresenter(IMainView View)
            : base(View)
        {

        }
        #endregion

        #region Properties

        public List<VUbicazioneAttiva> Ubicazioni { get; set; }
        public List<UbicazioneStorico> UbicazioniStorico { get; set; }

        public List<ProgIrrigazioneDato> Irrigazioni { get; set; }

        public List<VTracciaTestata> CicliProduzione { get; set; }
        public VTracciaTestata CicloProduzioneSel { get; set; }
        public List<MagazzinoMovimento> CicliProduzioneUbi { get; set; }
        public List<VTracciaMateriePrime> CicliProduzioneMP { get; set; }

        public DateTime ReportDal { get; set; } = DateTime.MinValue;
        public DateTime ReportAl { get; set; } = DateTime.MinValue;

        public List<Traccia> ElencoTracciabilita { get; set; }
        public List<TracciaDocVendita> ElencoTracciabilitaDocVendita { get; set; }
        public List<MagazzinoMovimento> ElencoTracciabilitaConf { get; set; }

        public VUbicazioneAttiva UbicazioneSelezionata { get; set; }

        public List<VMovimentoGiacenza> ListaMovCaricoUbicazioneSelezionata { get; set; }
            = new List<VMovimentoGiacenza>();
        public List<VMovimentoGiacenza> ListaMovScaricoUbicazioneSelezionata { get; set; }
            = new List<VMovimentoGiacenza>();

        public VMovimentoGiacenza MovimentoCarico { get; set; }
        public VMovimentoGiacenza MovimentoScarico { get; set; }

        public List<VStatsPivotVendita> ElencoStatsVendita { get; set; }

        public List<CicloLavorazione> CicliLavorazioni { get; set; } = new List<CicloLavorazione>();

        public MagazzinoMovimento MovimentoDettaglioSelezionato { get; set; }
        public VTracciaMateriePrime TracciaMPSelezionata { get; set; }

        #endregion

        #region IMainView

        protected override void CloseView(object sender, EventArgs e)
        {
            Dispose();
        }
        protected override void ViewInitialized(object sender, EventArgs e)
        {

        }


        #endregion

        #region Action

        internal void LoadTracciabilita(string LottoConfezionamento)
        {

            ElencoTracciabilita = Repository.Query<Traccia>
                (";EXEC stp_GetTracciabilitaFromConf @0", LottoConfezionamento).ToList();

            View.UpdateCurrentePage("listaTraccia");

        }
        internal void LoadTracciabilitaDocVendita(string LottoConfezionamento)
        {

            ElencoTracciabilitaDocVendita = Repository.Query<TracciaDocVendita>
                (";EXEC stp_GetTracciabilitaDocVenFromConf @0", LottoConfezionamento).ToList();

            View.UpdateCurrentePage("listaTracciaDocVendita");

        }
        internal void LoadTracciabilitaConf(string LottoConfezionamento)
        {

            string sql = "FROM MagazzinoMovimenti WHERE Lotto = @0 AND Causale = @1";
            ElencoTracciabilitaConf = Repository.Query<MagazzinoMovimento>(sql, LottoConfezionamento, "CONF").ToList();

            View.UpdateCurrentePage("listaTracciaConf");

        }

        internal void LoadUbicazioniAttive()
        {

            string sql = "FROM vw_UbicazioniAttive Order By Codice";
            Ubicazioni = Repository.Query<VUbicazioneAttiva>(sql).ToList();

            View.UpdateCurrentePage("listaUbicazioniAttive");

        }
        internal void LoadUbicazioniNonAttive()
        {

            string sql = "FROM vw_UbicazioniNonAttive Order By Codice";
            Ubicazioni = Repository.Query<VUbicazioneAttiva>(sql).ToList();

            View.UpdateCurrentePage("listaUbicazioniAttive");

        }

        internal void LoadUbicazioniStorico(DateTime Dal, DateTime Al)
        {

            string sql = "FROM UbicazioniStorico WHERE DataCreazione >= @0 AND DataCreazione <= @1 ORDER BY DataCreazione DESC";
            UbicazioniStorico = Repository.Query<UbicazioneStorico>(sql, Dal, Al).ToList();

            View.UpdateCurrentePage("listaUbicazioniStorico");

        }

        internal void LoadCicliProduzione(DateTime Dal, DateTime Al, string Ciclo)
        {

            var sqlBuilder = new SqlBuilder();
            var template = sqlBuilder.
                AddTemplate("SELECT * FROM vw_TracciaTestata WHERE (DataDocumento >= @0 AND DataDocumento <= @1) AND /**where**/ ORDER BY DataDocumento DESC", Dal, Al);

            if (Ciclo != "ALL")
            {
                sqlBuilder.Where("CicloProduzione = @0", Ciclo);
            }

            CicliProduzione = Repository.Query<VTracciaTestata>(template).ToList();

            View.UpdateCurrentePage("listaCicliProduzione");

        }

        internal void LoadCicliFilter()
        {

            CicliLavorazioni.Clear();
            string sql = "SELECT * FROM CicliLavorazione ORDER BY Descrizione";
            CicliLavorazioni = Repository.Query<CicloLavorazione>(sql).ToList();

            CicliLavorazioni.Insert(0, new CicloLavorazione()
            {
                Id = 0,
                Codice = "ALL",
                Descrizione = "TUTTI"
            });

            View.UpdateCurrentePage("listaCicliLavorazioni");

        }

        internal void GeneraReport(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    ReportMateriePrime();
                    break;
                case 1:
                    ReportVendite();
                    break;
                case 2:
                    ReportIrrigazioni();
                    break;
                case 3:
                    ReportSemine();
                    break;
                case 4:
                    ReportFertirrigazione();
                    break;
                case 5:
                    ReportQC();
                    break;
                case 6:
                    ReportGiacenze();
                    break;
                case 7:
                    ReportBilancioMassa();
                    break;
                case 8:
                    ReportTorba();
                    break;
                case 9:
                    StatisticaVendita();
                    break;

            }
        }
        internal void GeneraXls(int selectedIndex, string FileName)
        {
            switch (selectedIndex)
            {
                case 0:
                    ExportMateriePrime(FileName);
                    break;
                case 1:
                    ExportVendite(FileName);
                    break;
                case 2:
                    ExportIrrigazioni(FileName);
                    break;
                case 3:
                    ExportSemine(FileName);
                    break;
                case 4:
                    ExportFertirrigazione(FileName);
                    break;
                case 5:
                    ExportQC(FileName);
                    break;
                case 6:
                    ExportGiacenze(FileName);
                    break;
                case 7:
                    ExportBilancioMassa(FileName);
                    break;
                case 8:
                    ExportTorba(FileName);
                    break;
                case 9:
                    break;

            }
        }

        internal void LoadMovimentiUbicazioneAttiva()
        {

            string sqlCarico = "FROM vw_MovimentiGiacenzaCarico WHERE Lotto = @0 AND Ubicazione = @1";
            string sqlScarico = "FROM vw_MovimentiGiacenzaScarico WHERE (Lotto = @0 AND UbicazionePrecedente = @1) OR (LottoOrigine = @0 AND UbicazionePrecedente = @1)";


            ListaMovCaricoUbicazioneSelezionata = Repository.Query<VMovimentoGiacenza>
                (sqlCarico, UbicazioneSelezionata.Lotto, UbicazioneSelezionata.Codice).ToList();



            ListaMovScaricoUbicazioneSelezionata = Repository.Query<VMovimentoGiacenza>
                (sqlScarico, UbicazioneSelezionata.Lotto, UbicazioneSelezionata.Codice).ToList();

            View.UpdateCurrentePage("ubicazioniLoadMovimentiCarScar");

        }

        internal void ClearMovimentiUbicazioneAttiva()
        {

            ListaMovCaricoUbicazioneSelezionata.Clear();
            ListaMovScaricoUbicazioneSelezionata.Clear();

            View.UpdateCurrentePage("ubicazioniLoadMovimentiCarScar");

        }

        internal void ReportCaricoScarico()
        {

            string sql = "SELECT * FROM vw_ReportCaricoScarico ORDER BY DataDocumento, Lotto, Ordinale";
            var ds = Repository.Query<VReportCaricoScarico>(sql).ToList();

            using (ReportCaricoScarico rpt =
                    new ReportCaricoScarico())
            {

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }
        }
        internal void ReportLavorazioni()
        {

            string sql = "SELECT * FROM vw_CicliProduzioneTestate ORDER BY DataDocumento";
            var ds = Repository.Query<VCicloProduzioneTestata>(sql).ToList();

            using (ReportLavorazioni rpt =
                    new ReportLavorazioni())
            {

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }
        }

        internal void ReportMateriePrime()
        {

            string sql = "SELECT * FROM vw_ReportMateriePrime WHERE DataDocumento >= @0 AND DataDocumento <= @1 ORDER BY DataDocumento";
            var ds = Repository.Query<VReportMateriaPrima>(sql, ReportDal, ReportAl).ToList();

            using (ReportMateriePrime rpt =
                    new ReportMateriePrime())
            {

                rpt.lblPeriodo.Text = $"Registro ACQUISTI dal {ReportDal.ToString("dd/MM/yyyy")} al {ReportAl.ToString("dd/MM/yyyy")}";

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }
        }
        internal void ExportMateriePrime(string FileName)
        {
            string sql = "SELECT * FROM vw_ReportMateriePrime WHERE DataDocumento >= @0 AND DataDocumento <= @1 ORDER BY DataDocumento";
            var Rows = Repository.Query<VReportMateriaPrima>(sql, ReportDal, ReportAl).ToList();
            var export = new ExportXls<VReportMateriaPrima>();
            export.Write(Rows, FileName);
        }

        internal void CancellaTestata()
        {

            string sqlMovMagazzino = "DELETE FROM MagazzinoMovimenti WHERE IdDocTestata = @0";
            string sqlTestata = "DELETE FROM DocumentiTestate WHERE Id = @0";

            try
            {
                Repository.StartConversation();

                int retDeleteMovMag = Repository.Execute(sqlMovMagazzino, CicloProduzioneSel.Id);
                int retDeleteTestata = Repository.Execute(sqlTestata, CicloProduzioneSel.Id);

                Repository.StopConversation();
            }
            catch (Exception ex)
            {
                Repository.AbortConversation();
                Logger.Error(ex.ToString());
            }

        }

        internal void ReportVendite()
        {

            string sql = "SELECT * FROM vw_ReportVendite WHERE DataDocumento >= @0 AND DataDocumento <= @1 ORDER BY DataDocumento";
            var ds = Repository.Query<VReportMateriaPrima>(sql, ReportDal, ReportAl).ToList();

            using (ReportVendite rpt =
                    new ReportVendite())
            {

                rpt.lblPeriodo.Text = $"Registro VENDITE dal {ReportDal.ToString("dd/MM/yyyy")} al {ReportAl.ToString("dd/MM/yyyy")}";

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }
        }
        internal void ExportVendite(string FileName)
        {

            string sql = "SELECT * FROM vw_ReportVendite WHERE DataDocumento >= @0 AND DataDocumento <= @1 ORDER BY DataDocumento";
            var Rows = Repository.Query<VReportMateriaPrima>(sql, ReportDal, ReportAl).ToList();
            var export = new ExportXls<VReportMateriaPrima>();
            export.Write(Rows, FileName);

        }

        internal void ReportIrrigazioni()
        {

            string sql = "SELECT * FROM ProgIrrigazioniDati WHERE DataIrrigazione >= @0 AND DataIrrigazione <= @1 ORDER BY DataIrrigazione";
            var ds = Repository.Query<ProgIrrigazioneDato>(sql, ReportDal, ReportAl).ToList();

            using (ReportIrrigazione rpt =
                    new ReportIrrigazione())
            {

                rpt.DataSource = ds;
                rpt.lblPeriodo.Text = $"ELENCO IRRIGAZIONI MAGAZZINO {ReportDal:dd/MM/yyyy} {ReportAl:dd/MM/yyyy}";
                rpt.ShowPreviewDialog();

            }
        }
        internal void ExportIrrigazioni(string FileName)
        {

            string sql = "SELECT * FROM ProgIrrigazioniDati WHERE DataIrrigazione >= @0 AND DataIrrigazione <= @1 ORDER BY DataIrrigazione";
            var Rows = Repository.Query<ProgIrrigazioneDato>(sql, ReportDal, ReportAl).ToList();
            var export = new ExportXls<ProgIrrigazioneDato>();
            export.Write(Rows, FileName);

        }

        internal void ReportSemine()
        {

            List<ReportCicloProduzione> ds = new List<ReportCicloProduzione>();


            string sql = ";EXEC stp_GetTracciaTestate @0,@1,@2";

            string sqlMov = ";EXEC stp_GetMovimentiByIdDocTestata @0";

            string sqlMP = ";EXEC stp_GetMateriePrimeByIdDocTestata @0";

            string sqlGetNumCarrelli = ";EXEC stp_GetNumeroCarrelli @0, @1";

            var listTrattamenti = Repository.Query<VTracciaTestata>(sql,
                                    "SEM",
                                    ReportDal.WithoutHH(),
                                    ReportAl.LastInclusive()).ToList();


            IdDTO DTO = new IdDTO()
            {
                Id = listTrattamenti.Select(c => c.Id).ToList()
            };
            string content = JsonConvert.SerializeObject(DTO);


            var listMovimenti = Repository.Query<MagazzinoMovimento>(sqlMov, content).ToList();

            var listaMP = Repository.Query<VTracciaMateriePrime>(sqlMP, content).ToList();

            var numcarrelli = Repository.Query<ReportSemNumCarrello>(sqlGetNumCarrelli,
                ReportDal.WithoutHH(),
                ReportAl.LastInclusive()).ToList();

            int? numCarrelli = 0;

            foreach (var item in listTrattamenti)
            {

                ReportCicloProduzione row = new ReportCicloProduzione();


                numCarrelli = (from x in numcarrelli
                               where x.Id == item.Id
                               select x.NumCarrelli).SingleOrDefault();

                item.Qta = 0;
                if (numCarrelli.HasValue)
                {
                    item.Qta = numCarrelli.Value * 36;
                }



                row.TracciaTestata = item;



                row.CicliProduzioneUbi = (from x in listMovimenti
                                          where x.IdDocTestata == item.Id
                                          select x).ToList();

                row.CicliProduzioneMP = (from x in listaMP
                                         where x.IdDocTestata == item.Id
                                         select x).ToList();


                ds.Add(row);

            }

            using (ReportCicliProduzioneSemine rpt =
                  new ReportCicliProduzioneSemine())
            {

                rpt.lblPeriodo.Text = $"Registro Semine dal {ReportDal.ToString("dd/MM/yyyy")} al {ReportAl.ToString("dd/MM/yyyy")}";

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }


        }
        internal void ExportSemine(string FileName)
        {

            string sql = ";EXEC stp_GetSemineExport @0,@1,@2";
            var Rows = Repository.Query<ExportSemina>(sql, "SEM",
                                                            ReportDal.WithoutHH(),
                                                            ReportAl.LastInclusive()).ToList();
            var export = new ExportXls<ExportSemina>();
            export.Write(Rows, FileName);

        }

        internal void ReportFertirrigazione()
        {

            List<ReportCicloProduzione> ds = new List<ReportCicloProduzione>();

            string sql = ";EXEC stp_GetTracciaTestate_Taniche @0,@1,@2";
            string sqlMov = ";EXEC stp_GetMovimentiByIdDocTestata @0";
            string sqlMP = ";EXEC stp_GetMateriePrimeByIdDocTestata @0";

            var listTrattamenti = Repository.Query<VTracciaTestata>(sql,
                                    "TAN",
                                    ReportDal.WithoutHH(),
                                    ReportAl.LastInclusive()).ToList();



            IdDTO DTO = new IdDTO()
            {
                Id = listTrattamenti.Select(c => c.Id).ToList()
            };
            string content = JsonConvert.SerializeObject(DTO);


            var listMovimenti = Repository.Query<MagazzinoMovimento>(sqlMov, content).ToList();

            var listaMP = Repository.Query<VTracciaMateriePrime>(sqlMP, content).ToList();


            foreach (var item in listTrattamenti)
            {

                ReportCicloProduzione row = new ReportCicloProduzione();

                row.TracciaTestata = item;



                row.CicliProduzioneUbi = (from x in listMovimenti
                                          where x.IdDocTestata == item.Id
                                          select x).ToList();

                row.CicliProduzioneMP = (from x in listaMP
                                         where x.IdDocTestata == item.Id
                                         select x).ToList();


                ds.Add(row);

            }

            using (ReportCicliProduzioneTaniche rpt =
                  new ReportCicliProduzioneTaniche())
            {

                rpt.lblPeriodo.Text = $"Registro Carico Taniche dal {ReportDal.ToString("dd/MM/yyyy")} al {ReportAl.ToString("dd/MM/yyyy")}";

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }


        }
        internal void ExportFertirrigazione(string FileName)
        {

            string sql = ";EXEC stp_GetTracciaTestate_Taniche @0,@1,@2";
            string sqlMP = ";EXEC stp_GetMateriePrimeByIdDocTestata @0";

            var listTrattamenti = Repository.Query<VTracciaTestata>(sql,
                                    "TAN",
                                    ReportDal.WithoutHH(),
                                    ReportAl.LastInclusive()).ToList();

            IdDTO DTO = new IdDTO()
            {
                Id = listTrattamenti.Select(c => c.Id).ToList()
            };
            string content = JsonConvert.SerializeObject(DTO);

            var Rows = Repository.Query<VTracciaMateriePrime>(sqlMP, content).ToList();
            var export = new ExportXls<VTracciaMateriePrime>();

            export.Write(Rows, FileName);

        }

        internal void ReportTorba()
        {

            List<ReportCicloProduzione> ds = new List<ReportCicloProduzione>();


            string sql = ";EXEC stp_GetTracciaTestate_Torba @0,@1,@2";
            string sqlMov = ";EXEC stp_GetMovimentiByIdDocTestata @0";

            string sqlMP = ";EXEC stp_GetMateriePrimeByIdDocTestata @0";

            var listTrattamenti = Repository.Query<VTracciaTestata>(sql,
                                    "TAN",
                                    ReportDal.WithoutHH(),
                                    ReportAl.LastInclusive()).ToList();



            IdDTO DTO = new IdDTO()
            {
                Id = listTrattamenti.Select(c => c.Id).ToList()
            };
            string content = JsonConvert.SerializeObject(DTO);


            var listMovimenti = Repository.Query<MagazzinoMovimento>(sqlMov, content).ToList();

            var listaMP = Repository.Query<VTracciaMateriePrime>(sqlMP, content).ToList();


            foreach (var item in listTrattamenti)
            {

                ReportCicloProduzione row = new ReportCicloProduzione();

                row.TracciaTestata = item;



                row.CicliProduzioneUbi = (from x in listMovimenti
                                          where x.IdDocTestata == item.Id
                                          select x).ToList();

                row.CicliProduzioneMP = (from x in listaMP
                                         where x.IdDocTestata == item.Id
                                         select x).ToList();


                ds.Add(row);

            }

            using (ReportCicliProduzioneTaniche rpt =
                  new ReportCicliProduzioneTaniche())
            {

                rpt.lblPeriodo.Text = $"Registro Utilizzo Torba dal {ReportDal.ToString("dd/MM/yyyy")} al {ReportAl.ToString("dd/MM/yyyy")}";

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }


        }
        internal void ExportTorba(string FileName)
        {
            string sql = ";EXEC stp_GetTorbaExport @0,@1,@2";
            var Rows = Repository.Query<ExportTorba>(sql, "TAN",
                                                            ReportDal.WithoutHH(),
                                                            ReportAl.LastInclusive()).ToList();
            var export = new ExportXls<ExportTorba>();
            export.Write(Rows, FileName);
        }

        internal void ReportBilancioMassa()
        {

            List<ReportBilancioMassaDto> ds = new List<ReportBilancioMassaDto>();


            string sql = ";EXEC stp_GetBilancioMassa @0,@1";


            ds = Repository.Query<ReportBilancioMassaDto>(sql,
                                    ReportDal.WithoutHH(),
                                    ReportAl.LastInclusive()).ToList();


            var qryGrouped = from x in ds group x by x.Lotto into g select g;

            foreach (var item in qryGrouped)
            {
                var rows = (from x in ds where x.Lotto == item.Key select x).ToList();

                if (rows.Count() > 1)
                {

                    var totQta = rows.Select(c => c.QtaCarico).Sum();
                    var unitaDist = rows[0].QtaDist / totQta;

                    foreach (var internalRow in rows)
                    {
                        if (internalRow.Formato == "FG" & internalRow.QtaDist != 0)
                        {
                            internalRow.QtaDist = (int)(internalRow.QtaCarico * unitaDist * 20);
                        }
                        if (internalRow.Formato == "VA" & internalRow.QtaDist != 0)
                        {
                            internalRow.QtaDist = (int)(internalRow.QtaCarico * unitaDist);
                        }
                    }

                }
                else
                {

                    if (rows[0].Formato == "FG" & rows[0].QtaDist != 0)
                    {
                        rows[0].QtaDist = rows[0].QtaDist * 20;
                    }

                }


            }



            using (ReportBilancioMassa rpt =
                  new ReportBilancioMassa())
            {

                rpt.lblPeriodo.Text = $"Bilancio di massa dal {ReportDal.ToString("dd/MM/yyyy")} al {ReportAl.ToString("dd/MM/yyyy")}";

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }


        }
        internal void ExportBilancioMassa(string FileName)
        {
            List<ReportBilancioMassaDto> ds = new List<ReportBilancioMassaDto>();


            string sql = ";EXEC stp_GetBilancioMassa @0,@1";


            ds = Repository.Query<ReportBilancioMassaDto>(sql,
                                    ReportDal.WithoutHH(),
                                    ReportAl.LastInclusive()).ToList();


            var qryGrouped = from x in ds group x by x.Lotto into g select g;

            foreach (var item in qryGrouped)
            {
                var rows = (from x in ds where x.Lotto == item.Key select x).ToList();

                if (rows.Count() > 1)
                {

                    var totQta = rows.Select(c => c.QtaCarico).Sum();
                    var unitaDist = rows[0].QtaDist / totQta;

                    foreach (var internalRow in rows)
                    {
                        if (internalRow.Formato == "FG" & internalRow.QtaDist != 0)
                        {
                            internalRow.QtaDist = (int)(internalRow.QtaCarico * unitaDist * 20);
                        }
                        if (internalRow.Formato == "VA" & internalRow.QtaDist != 0)
                        {
                            internalRow.QtaDist = (int)(internalRow.QtaCarico * unitaDist);
                        }
                    }

                }
                else
                {

                    if (rows[0].Formato == "FG" & rows[0].QtaDist != 0)
                    {
                        rows[0].QtaDist = rows[0].QtaDist * 20;
                    }

                }


            }

            var export = new ExportXls<ReportBilancioMassaDto>();
            export.Write(ds, FileName);

        }

        internal void StatisticaVendita()
        {
            string sqlStats = "FROM vw_StatsPivotVendite WHERE DataDocumento >= @0 AND DataDocumento <= @1";
            ElencoStatsVendita = Repository.Query<VStatsPivotVendita>(sqlStats,
                                 ReportDal.WithoutHH(),
                                 ReportAl.LastInclusive()).ToList();
            View.UpdateCurrentePage("StatsPivotVendita");
        }

        internal void ReportQC()
        {

            List<ReportQCTestata> Testate;
            List<ReportQCDettaglio> Dettagli;

            string sqlTestata = ";EXEC stp_GetQCTestate @0, @1";

            string sqlRighe = ";EXEC stp_GETQCDettaglio @0";
            string sqlRigheBosco = ";EXEC stp_GETQCDettaglioBosco @0";

            Testate = Repository.Query<ReportQCTestata>(sqlTestata,
                                ReportDal.WithoutHH(),
                                ReportAl.LastInclusive()).ToList();

            IdDTO dtoTotale = new IdDTO()
            {
                Id = Testate.Select(c => c.Id).ToList()
            };

            IdDTO dtoBasilico = new IdDTO()
            {
                Id = Testate.Where(c => c.TipoRiga == "BASILICO").Select(c => c.Id).ToList()
            };
            IdDTO dtoBosco = new IdDTO()
            {
                Id = Testate.Where(c => c.TipoRiga == "BOSCO").Select(c => c.Id).ToList()
            };

            string content = JsonConvert.SerializeObject(dtoBasilico);

            Dettagli = Repository.Query<ReportQCDettaglio>(sqlRighe, content).ToList();

            string contentBosco = JsonConvert.SerializeObject(dtoBosco);

            var dettagliBosco = Repository.Query<ReportQCDettaglio>(sqlRigheBosco, contentBosco).ToList();

            if (dettagliBosco.Count != 0)
            {
                Dettagli.AddRange(dettagliBosco);
            }


            foreach (var Id in dtoTotale.Id)
            {

                var testata = (from x in Testate
                               where x.Id == Id
                               select x).SingleOrDefault();

                testata.Dettaglio = (from x in Dettagli
                                     where x.IdTestata == Id
                                     select x).ToList();

            }


            using (ReportQC rpt =
                 new ReportQC())
            {

                ReportQCDto Base = new ReportQCDto()
                {
                    Testate = Testate
                };

                ReportQCCollection ds = new ReportQCCollection();
                ds.Add(Base);

                rpt.lblPeriodo.Text = $"Quaderno di campagna dal {ReportDal.ToString("dd/MM/yyyy")} al {ReportAl.ToString("dd/MM/yyyy")}";

                rpt.DataSource = ds;
                rpt.ShowPreviewDialog();

            }


        }
        internal void ExportQC(string FileName)
        {

            List<ReportQCTestata> Testate;

            string sqlTestata = ";EXEC stp_GetQCTestate @0, @1";

            Testate = Repository.Query<ReportQCTestata>(sqlTestata,
                                ReportDal.WithoutHH(),
                                ReportAl.LastInclusive()).ToList();

            IdDTO DTO = new IdDTO()
            {
                Id = Testate.Select(c => c.Id).ToList()
            };

            string content = JsonConvert.SerializeObject(DTO);

            string sqlQC = ";EXEC stp_GetQcExport @0, @1, @2";


            var Rows = Repository.Query<ExportQC>(sqlQC, ReportDal.WithoutHH(),
                ReportAl.LastInclusive(),
                content).ToList();

            var export = new ExportXls<ExportQC>();
            export.Write(Rows, FileName);

        }

        internal void ReportGiacenze()
        {

            string sqlRipilogoFrom = "SELECT *  FROM fnc_GetGiacenzaAllaData(@0) ORDER BY DescrizioneArticolo, Lotto";
            string sqlRipilogoTo = "SELECT *  FROM fnc_GetGiacenzaAllaData(@0) ORDER BY DescrizioneArticolo, Lotto";
            string sqlRipilogoMovimenti = "SELECT * FROM fnc_GetMovimentiGiacPeriodo(@0, @1) ORDER BY DescrizioneArticolo, Lotto, DataDocumento";

            IList<Giacenza> GiacenzaIniziale = Repository.Query<Giacenza>(sqlRipilogoFrom, ReportDal).ToList();
            IList<Giacenza> GiacenzaFinale = Repository.Query<Giacenza>(sqlRipilogoTo, ReportAl).ToList();
            IList<GiacenzaMovimento> GiacenzaMovimenti = Repository.Query<GiacenzaMovimento>(sqlRipilogoMovimenti, ReportDal, ReportAl).ToList();


            GiacenzaCollection GiacenzaInizialeDs = new GiacenzaCollection(GiacenzaIniziale);
            GiacenzaCollection GiacenzaFinaleDs = new GiacenzaCollection(GiacenzaFinale);
            GiacenzaMovimentoCollection GiacenzaMovDs = new GiacenzaMovimentoCollection(GiacenzaMovimenti);

            ReportGiacenzaRiepilogo ReportGiacIniziale = new ReportGiacenzaRiepilogo();
            ReportGiacIniziale.DataSource = GiacenzaInizialeDs;
            ReportGiacIniziale.lblPeriodo.Text = $"GIACENZE INIZIALE MAGAZZINO AL {ReportDal:dd/MM/yyyy}";
            ReportGiacIniziale.CreateDocument();

            ReportGiacenzaRiepilogo ReportGiacFinale = new ReportGiacenzaRiepilogo();
            ReportGiacFinale.DataSource = GiacenzaFinaleDs;
            ReportGiacFinale.lblPeriodo.Text = $"GIACENZE FINALE MAGAZZINO AL {ReportAl:dd/MM/yyyy}";
            ReportGiacFinale.CreateDocument();

            ReportGiacenzaDettaglio ReportMovimenti = new ReportGiacenzaDettaglio();
            ReportMovimenti.DataSource = GiacenzaMovDs;
            ReportMovimenti.lblPeriodo.Text = $"MOVIMENTI MAGAZZINO DAL {ReportDal:dd/MM/yyyy} AL {ReportAl:dd/MM/yyyy}";
            ReportMovimenti.CreateDocument();

            ReportGiacIniziale.ModifyDocument(x =>
            {
                x.AddPages(ReportMovimenti.Pages);
            });

            ReportGiacIniziale.ModifyDocument(x =>
            {
                x.AddPages(ReportGiacFinale.Pages);
            });

            ReportGiacIniziale.ShowPreviewDialog();

        }
        internal void ExportGiacenze(string FileName)
        {

            string fName = Path.GetFileNameWithoutExtension(FileName);
            string path = Path.GetDirectoryName(FileName);
            string ext = Path.GetExtension(FileName);

            string fNameIniziale = Path.Combine(path, fName + "_GiacIniziale" + ext);
            string fNameFinale = Path.Combine(path, fName + "_GiacFinale" + ext);
            string fNameMovimenti = Path.Combine(path, fName + "_GiacMovimenti" + ext);


            string sqlRipilogoFrom = "SELECT *  FROM fnc_GetGiacenzaAllaData(@0) ORDER BY DescrizioneArticolo, Lotto";
            string sqlRipilogoTo = "SELECT *  FROM fnc_GetGiacenzaAllaData(@0) ORDER BY DescrizioneArticolo, Lotto";
            string sqlRipilogoMovimenti = "SELECT * FROM fnc_GetMovimentiGiacPeriodo(@0, @1) ORDER BY DescrizioneArticolo, Lotto, DataDocumento";

            IList<Giacenza> GiacenzaIniziale = Repository.Query<Giacenza>(sqlRipilogoFrom, ReportDal).ToList();
            IList<Giacenza> GiacenzaFinale = Repository.Query<Giacenza>(sqlRipilogoTo, ReportAl).ToList();
            IList<GiacenzaMovimento> GiacenzaMovimenti = Repository.Query<GiacenzaMovimento>(sqlRipilogoMovimenti, ReportDal, ReportAl).ToList();

            var exportIniziale = new ExportXls<Giacenza>();
            exportIniziale.Write(GiacenzaIniziale, fNameIniziale);

            var exportFinale = new ExportXls<Giacenza>();
            exportFinale.Write(GiacenzaFinale, fNameFinale);

            var exportMovimenti = new ExportXls<GiacenzaMovimento>();
            exportMovimenti.Write(GiacenzaMovimenti, fNameMovimenti);

        }

        internal List<string> ImportIrrigazioni(List<string> Rows)
        {
            List<string> Errors = new List<string>();
            List<ProgIrrigazioneDato> letture = new List<ProgIrrigazioneDato>();


            int counter = 0;
            bool isOk = false;

            try
            {

                foreach (var item in Rows)
                {

                    //if (counter == 44)
                    //{
                    //    Debugger.Break();
                    //}


                    if (item.IndexOf("ALLARME") == -1)
                    {
                        isOk = true;
                    }
                    else
                    {
                        isOk = false;
                    }

                    if (isOk)
                    {

                        ProgIrrigazioneDato lettura = new ProgIrrigazioneDato();

                        string[] token = item.Split(',').Select(x => x.Trim()).ToArray();

                        CultureInfo provider = CultureInfo.InvariantCulture;
                        string[] formatDate = { "dd/MM/yyyy  H.mm", "dd/MM/yyyy  H:mm" };
                        string[] token0 = token[0].Split('|').Select(x => x.Trim()).ToArray();

                        lettura.DataIrrigazione = DateTime.ParseExact(token0[0], formatDate, provider, DateTimeStyles.None);
                        lettura.CodiceProgramma = token0[1];
                        lettura.Litri = int.Parse(token[4].Replace("LITRI=", string.Empty).Replace("OK", string.Empty).Replace("NOK", string.Empty).Replace("N", string.Empty));
                        letture.Add(lettura);

                    }
                    else
                    {
                        Logger.Warn("IMPORTAZIONE IRRIGIAZIONI, rilevato ALLARME");
                    }


                    counter++;

                }


                Repository.InsertBulk<ProgIrrigazioneDato>(letture);


            }
            catch (Exception ex)
            {
                Errors.Add($"{ex.Message} RIGA # {counter}");
                Logger.Error(ex.ToString());
            }

            return Errors;

        }

        internal void SetTestataTraccia(VTracciaTestata Item)
        {

            if (Item != null)
            {
                CicloProduzioneSel = Item;
                LoadMovimentoMP(Item);
            }

        }

        internal void LoadMovimentoMP(VTracciaTestata Item)
        {
            string sql = "FROM MagazzinoMovimenti WHERE IdDocTestata = @0 AND Causale <> @1";
            CicliProduzioneUbi = Repository.Query<MagazzinoMovimento>(sql, Item.Id, "SMG").ToList();

            string sqlMP = "SELECT *  FROM vw_TracciaMatPrime WHERE IdDocTestata = @0";
            CicliProduzioneMP = Repository.Query<VTracciaMateriePrime>(sqlMP, Item.Id).ToList();

            View.UpdateCurrentePage("listaCicliProduzioneDett");
        }

        internal void SetMovimentoDettaglioSelezionato(MagazzinoMovimento Item)
        {
            MovimentoDettaglioSelezionato = Item;
            View.UpdateCurrentePage("movimentoDettaglioSelezionato");
        }

        internal void SetTracciaMPSelezionata(VTracciaMateriePrime Item)
        {
            TracciaMPSelezionata = Item;
            View.UpdateCurrentePage("tracciaMPSelezionata");
        }

        internal void ManageMovimentoDettaglio()
        {

            Repository.Update(MovimentoDettaglioSelezionato);
            LoadMovimentoMP(CicloProduzioneSel);

        }

        internal void ManageTracciaMP()
        {

            string sql = "FROM MagazzinoMovimenti WHERE Id = @0";
            var movimento = Repository.Query<MagazzinoMovimento>
                (sql, TracciaMPSelezionata.IdMovimento).FirstOrDefault();

            movimento.Qta = TracciaMPSelezionata.Qta;

            Repository.Update(movimento);
            LoadMovimentoMP(CicloProduzioneSel);

        }

        internal void CancellaMovimentoDettaglio()
        {

            Repository.Delete(MovimentoDettaglioSelezionato);
            LoadMovimentoMP(CicloProduzioneSel);

        }

        internal void CancellaTracciaMP()
        {

            string sql = "DELETE FROM MagazzinoMovimenti WHERE Id = @0";
            Repository.Execute(sql, TracciaMPSelezionata.IdMovimento);
            LoadMovimentoMP(CicloProduzioneSel);

        }

        internal void SetUbicazioneSelezionata(VUbicazioneAttiva Ubicazione)
        {
            UbicazioneSelezionata = Ubicazione;
            View.UpdateCurrentePage("ubicazioniSetUbSelezionata");
        }

        internal void SetMovimentoCarico(VMovimentoGiacenza Item)
        {
            MovimentoCarico = Item;
            MovimentoScarico = null;
            View.UpdateCurrentePage("ubicazioniSetMovimentoCarico");
        }
        internal void SetMovimentoScarico(VMovimentoGiacenza Item)
        {
            MovimentoScarico = Item;
            MovimentoCarico = null;
            View.UpdateCurrentePage("ubicazioniSetMovimentoScarico");
        }

        internal void LoadIrrigazioni(DateTime Dal, DateTime Al)
        {

            string sql = "FROM ProgIrrigazioniDati WHERE DataIrrigazione >= @0 AND DataIrrigazione <= @1 ORDER BY DataIrrigazione";

            Irrigazioni = Repository.Query<ProgIrrigazioneDato>(sql, Dal, Al).ToList();

            View.UpdateCurrentePage("listaIrrigazioni");

        }

        internal void DeleteProgIrrigazioneDati(List<int> Id)
        {

            string sql = "DELETE FROM ProgIrrigazioniDati WHERE Id IN (@0)";
            Repository.Execute(sql, Id);

        }

        internal List<UbicazioneStorico> GetUbicazioniStoricoRiapri()
        {

            List<UbicazioneStorico> ret = new List<UbicazioneStorico>();
            string sql = "EXEC stp_GetUbicazioneStoricoRiapertura @0";

            ret = Repository.Query<UbicazioneStorico>
                (sql, UbicazioneSelezionata.Codice).ToList();

            return ret;

        }

        internal void RiapriUbicazione(UbicazioneStorico Storico)
        {

            try
            {

                Repository.StartConversation();

                string sqlUbicazione = "UPDATE Ubicazioni SET Lotto = @0 WHERE Codice = @1";

                Repository.Execute(sqlUbicazione, Storico.Lotto, UbicazioneSelezionata.Codice);

                string sql = "UPDATE UbicazioniStorico SET DataChiusura = NULL WHERE Id = @0";
                Repository.Execute(sql, Storico.Id);

                Repository.StopConversation();

            }
            catch (Exception ex)
            {

                Repository.AbortConversation();
                throw ex;

            }

        }

        internal void ChiudiUbicazione()
        {

            try
            {

                Repository.StartConversation();

                string sqlUbicazione = "UPDATE Ubicazioni SET Lotto = NULL WHERE Codice = @0";

                Repository.Execute(sqlUbicazione, UbicazioneSelezionata.Codice);

                string sql = "FROM UbicazioniStorico WHERE Ubicazione = @0 AND DataChiusura IS NULL";
                var storico = Repository.Query<UbicazioneStorico>(sql, UbicazioneSelezionata.Codice).SingleOrDefault();

                if (storico != null)
                {
                    storico.DataChiusura = DateTime.Now;
                    Repository.Update(storico);
                }
                else
                {
                    throw new ApplicationException($"Non c'è un storico aperto per {UbicazioneSelezionata.Codice}");
                }

                Repository.StopConversation();

            }
            catch (Exception ex)
            {

                Repository.AbortConversation();
                throw ex;

            }

        }

        internal void SalvaMovimento(VMovimentoGiacenza Movimento)
        {

            var movimento = Repository.Query<MagazzinoMovimento>
                ("FROM MagazzinoMovimenti WHERE Id = @0", Movimento.Id).SingleOrDefault();

            movimento.Qta = Movimento.Qta;
            movimento.QtaPrecedente = Movimento.QtaPrecedente;

            Repository.Update(movimento);
            LoadMovimentiUbicazioneAttiva();

        }

        #endregion

    }
}
