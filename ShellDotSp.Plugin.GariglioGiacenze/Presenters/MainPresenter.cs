#region UI
using System;
using System.Collections.Generic;
using System.Linq;
using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioGiacenze.Interfaces;
#endregion

namespace ShellDotSp.Plugin.GariglioGiacenze.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        #region Fields

        #endregion

        #region Properties

        public List<VGiacenza> Giacenze { get; set; }
        public VGiacenza GiacenzaSelezionata { get; set; }

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
            LoadGiacenze();
        }
        #endregion

        #region Action

        internal void LoadGiacenze()
        {
            Giacenze = Repository.Query<VGiacenza>
                ("FROM vw_Giacenze WHERE Giacenza <> 0").ToList();

            View.UpdateUI(Function.ElencoGiacenze);
        }

        internal void SetGiacenza(VGiacenza GiacenzaSelezionata)
        {
            this.GiacenzaSelezionata = GiacenzaSelezionata;
            View.UpdateUI(Function.GiacenzaSelezionata);
        }

        internal void EseguiRettifica(decimal QtaRettifica)
        {
            string causale = string.Empty;

            if (QtaRettifica < 0)
            {
                causale = "RMN";
            }
            else
            {
                causale = "RMP";
            }

            string sqlArt = "FROM Articoli WHERE Id = @0";
            var articolo = Repository.Query<Articolo>(sqlArt, GiacenzaSelezionata.IdArticolo).SingleOrDefault();

            var testata = new DocumentoTestata();
            testata.Id = 0;
            testata.DataDocumento = DateTime.Today;
            testata.Tipo = "LAV";
            testata.CicloProduzione = "RMG";

            Repository.Insert(testata);

            MagazzinoMovimento movimento = new MagazzinoMovimento();
            movimento.IdArticolo = GiacenzaSelezionata.IdArticolo;
            movimento.UM = articolo.Um;
            movimento.CodiceMagazzino = "001";
            movimento.Causale = causale;
            movimento.Lotto = GiacenzaSelezionata.Lotto;
            movimento.Qta = Math.Abs(QtaRettifica);
            movimento.IdDocTestata = testata.Id;
            movimento.IdDocRiga = 0;
            movimento.TsCreazione = DateTime.Now;

            Repository.Insert(movimento);

            LoadGiacenze();

        }
        #endregion

    }
}
