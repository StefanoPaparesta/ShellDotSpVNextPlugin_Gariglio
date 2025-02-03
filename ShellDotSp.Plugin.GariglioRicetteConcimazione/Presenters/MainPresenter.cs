#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.Interfaces;
#endregion

namespace ShellDotSp.Plugin.GariglioRicetteConcimazione.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        #region Fields
        private List<string> CodiceMezziTecnici = new List<string>() { "CC", "TB" };
        private const string CodiceTaniche = "TANICA";
        #endregion

        #region Properties
        public RicettaIrrigazioneTestata RicettaSelezionata { get; set; }
        public List<RicettaIrrigazioneTestata> ElencoRicette { get; set; }
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

        internal List<Articolo> LoadFertilizzanti()
        {

            string sql = "FROM Articoli WHERE Categoria IN (@0) ORDER BY Descrizione";
            return Repository.Query<Articolo>(sql, CodiceMezziTecnici).ToList();

        }

        internal List<VRicettaDettaglio> LoadDettaglioRicettaSelezionata()
        {

            var ret = new List<VRicettaDettaglio>();

            if (RicettaSelezionata != null)
            {

                string sql = "FROM vw_RicetteDettaglio WHERE IdTestata = @0 ORDER BY CodiceTanica";
                ret = Repository.Query<VRicettaDettaglio>(sql, RicettaSelezionata.Id).ToList();

            }

            return ret;

        }

        internal List<Ubicazione> LoadTaniche()
        {

            string sql = "FROM Ubicazioni WHERE Categoria = @0 ORDER BY Descrizione";
            return Repository.Query<Ubicazione>(sql, CodiceTaniche).ToList();

        }

        protected override void ViewInitialized(object sender, EventArgs e)
        {

            ElencoRicette = Repository.Query<RicettaIrrigazioneTestata>
              ("FROM RicetteIrrigazioneTestate ORDER BY DataInizioUtilizzo DESC")
              .ToList();

            View.UpdateUI(Function.ElencoRicette);

        }

        internal void CancellaDettaglioRicetta(VRicettaDettaglio DettSelezionato)
        {

            string sql = "DELETE FROM RicetteIrrigazioneDettaglio WHERE ID = @0";
            Repository.Execute(sql, DettSelezionato.Id);

        }

        #endregion

        #region Method
        internal void SetRicettaSelezionata(RicettaIrrigazioneTestata Ricetta)
        {
            RicettaSelezionata = Ricetta;
            View.UpdateUI(Function.RicettaSelezionata);
        }

        internal void ManageRicetta(RicettaIrrigazioneTestata RicettaSelezionata)
        {

            string sql = "FROM RicetteIrrigazioneTestate WHERE DataFineUtilizzo IS NULL";

            var elenco = Repository
                .Query<RicettaIrrigazioneTestata>(sql)
                .ToList();

            if (elenco.Count == 1 && elenco[0].Id != RicettaSelezionata.Id)
            {

                elenco[0].DataFineUtilizzo = RicettaSelezionata
                    .DataInizioUtilizzo.Value.AddDays(-1);

                Repository.Update(elenco[0]);

            }


            if (RicettaSelezionata.Id == 0)
            {

                Repository.Insert(RicettaSelezionata);

            }
            else
            {
                Repository.Update(RicettaSelezionata);
            }


        }

        internal void CancellaRicetta()
        {

            string sql = "DELETE FROM RicetteIrrigazioneTestate WHERE Id = @0";
            Repository.Execute(sql, RicettaSelezionata.Id);
            string sqlDett = "DELETE FROM RicetteIrrigazioneDettaglio WHERE IdTestata = @0";
            Repository.Execute(sqlDett, RicettaSelezionata.Id);

        }

        internal void AddDettaglioRicetta(RicettaIrrigazioneDettaglio Dettaglio)
        {

            Repository.Insert(Dettaglio);

        }

        #endregion

    }
}
