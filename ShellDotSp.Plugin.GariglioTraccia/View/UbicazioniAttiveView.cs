#region Using
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioTraccia.Forms;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.View
{
    public partial class UbicazioniAttiveView : UserControl, ILocalView
    {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Properties
        public Movimento MovimentoSelezionato { get; set; }
        #endregion

        #region Ctor

        public UbicazioniAttiveView(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }

        #endregion

        #region Implement ILocalView

        public void OnFinalize()
        {

        }

        public void OnInit()
        {

            btnAggiungi.Enabled = false;
            btnCambiaQta.Enabled = false;

            cmbFiltro.SelectedIndex = 0;

        }

        public void UpdateUI(string functionName)
        {

            switch (functionName)
            {
                case "listaUbicazioniAttive":

                    bndData.DataSource = Presenter.Ubicazioni;

                    break;
                case "ubicazioniSetUbSelezionata":

                    VerificaDropDownMenu();

                    break;
                case "ubicazioniLoadMovimentiCarScar":

                    bndCarico.DataSource = Presenter.ListaMovCaricoUbicazioneSelezionata;
                    bndScarico.DataSource = Presenter.ListaMovScaricoUbicazioneSelezionata;

                    CalcolaGiacenza();

                    break;
                case "ubicazioniSetMovimentoCarico":

                    VerificaDropDownMenuMovimenti();

                    break;
                case "ubicazioniSetMovimentoScarico":

                    VerificaDropDownMenuMovimenti();

                    break;
                default:
                    break;
            }


        }

        #endregion

        #region UI

        private void GridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.Views[0] as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            view.SelectRow(hitInfo.RowHandle);

            if ((e.Button & MouseButtons.Left) != 0 &
                hitInfo.InRow &
                !view.IsGroupRow(hitInfo.RowHandle))
            {
                if (view.GetSelectedRows().Length == 1)
                {

                    Presenter.SetUbicazioneSelezionata(
                        (VUbicazioneAttiva)view.GetRow(hitInfo.RowHandle));

                }
            }
        }

        private void BtnModifica_Click(object sender, System.EventArgs e)
        {

            //using (FrmAnagrafica Frm =
            //    new FrmAnagrafica(Presenter.AnagraficaSelezionata))
            //    {

            //    if (Frm.ShowDialog()
            //        == DialogResult.OK)
            //        {

            //        Presenter.ManageAnagrafica(Frm.Model);
            //        Presenter.AnagraficaSelezionata = null;
            //        Presenter.LoadAnagrafiche();

            //        }

            //    }

        }

        private void btnFiltra_Click(object sender, System.EventArgs e)
        {

            LoadGrid();

        }

        private void btnStampa_Click(object sender, System.EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btnActions_Click(object sender, System.EventArgs e)
        {
            VerificaDropDownMenu();
            btnActions.ShowDropDown();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            LoadGrid();

            VerificaDropDownMenu();

        }

        private void VerificaDropDownMenu()
        {

            btnRiapriUbicazione.Enabled = cmbFiltro.SelectedIndex == 1
                && Presenter.UbicazioneSelezionata != null;

            btnChiudiUbicazione.Enabled = cmbFiltro.SelectedIndex == 0
                && Presenter.UbicazioneSelezionata != null;

            if (cmbFiltro.SelectedIndex != 0)
            {

                bndCarico.Clear();
                bndScarico.Clear();

                Presenter.ListaMovCaricoUbicazioneSelezionata.Clear();
                Presenter.ListaMovScaricoUbicazioneSelezionata.Clear();

                CalcolaGiacenza();

            }

        }

        private void VerificaDropDownMenuMovimenti()
        {

            bool IsMovimentoSelezionato = Presenter.MovimentoCarico != null | Presenter.MovimentoScarico != null;
            btnCambiaQta.Enabled = IsMovimentoSelezionato;

            if (IsMovimentoSelezionato)
            {

                if (Presenter.MovimentoCarico != null)
                {
                    MovimentoSelezionato = Movimento.Carico;
                }
                if (Presenter.MovimentoScarico != null)
                {
                    MovimentoSelezionato = Movimento.Scarico;
                }

            }
            else
            {
                MovimentoSelezionato = Movimento.None;
            }

        }

        private void LoadGrid()
        {
            if (cmbFiltro.SelectedIndex == 0)
            {
                Presenter.LoadUbicazioniAttive();
            }
            if (cmbFiltro.SelectedIndex == 1)
            {
                Presenter.LoadUbicazioniNonAttive();
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {

            if (e.Page.Equals(tabNavigationPage1))
            {
                Presenter.SetMovimentoCarico(null);
                Presenter.SetMovimentoScarico(null);

            }

            if (e.Page.Equals(tabNavigationPage2))
            {
                if (cmbFiltro.SelectedIndex == 0 &&
                    Presenter.UbicazioneSelezionata != null)
                {
                    Presenter.LoadMovimentiUbicazioneAttiva();
                }
                else
                {
                    bndCarico.Clear();
                    bndScarico.Clear();
                }
            }



        }

        private void CalcolaGiacenza()
        {
            decimal Carico = (from x in Presenter.ListaMovCaricoUbicazioneSelezionata
                              select x.QtaGiacenza).Sum();
            decimal Scarico = (from x in Presenter.ListaMovScaricoUbicazioneSelezionata
                               select x.QtaGiacenza).Sum();

            lblCarico.Text = Carico.ToString("n0");
            lblScarico.Text = Scarico.ToString("n0");

            lblGiacenza.Text = (Carico - Scarico).ToString("n0");

        }

        private void btnRiapriUbicazione_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmRiapriUbicazione Frm = new FrmRiapriUbicazione(Presenter))
            {

                if (Frm.ShowDialog() == DialogResult.OK)
                {

                    try
                    {

                        Presenter.RiapriUbicazione(Frm.UbicazioneStoricoSelezionato);

                        Presenter.UbicazioneSelezionata = null;
                        Presenter.ListaMovCaricoUbicazioneSelezionata.Clear();
                        Presenter.ListaMovScaricoUbicazioneSelezionata.Clear();

                        LoadGrid();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message,
                            "Gariglio",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }

                }

            }
        }

        private void btnChiudiUbicazione_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show($"Sei sicuro di voler chiudere l'ubicazione {Presenter.UbicazioneSelezionata.Codice} ?",
                "Gariglio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    Presenter.ChiudiUbicazione();

                    Presenter.UbicazioneSelezionata = null;
                    Presenter.ListaMovCaricoUbicazioneSelezionata.Clear();
                    Presenter.ListaMovScaricoUbicazioneSelezionata.Clear();

                    LoadGrid();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,
                           "Gariglio",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);

                }

            }
        }

        private void btnCambiaQta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MovimentoSelezionato != Movimento.None)
            {
                using (FrmCambiaQta Frm = new FrmCambiaQta(Presenter))
                {
                    Frm.MovimentoSelezionato = MovimentoSelezionato;
                    if (Frm.ShowDialog() == DialogResult.OK)
                    {
                        Presenter.SetMovimentoCarico(null);
                    }
                }
            }

        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {

        }

        //Movimenti carico
        private void gridControl2_MouseClick(object sender, MouseEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.Views[0] as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            view.SelectRow(hitInfo.RowHandle);

            if ((e.Button & MouseButtons.Left) != 0 &
                hitInfo.InRow &
                !view.IsGroupRow(hitInfo.RowHandle))
            {
                if (view.GetSelectedRows().Length == 1)
                {

                    Presenter.SetMovimentoCarico(
                        (VMovimentoGiacenza)view.GetRow(hitInfo.RowHandle));

                }
            }
        }

        //Movimenti scarico
        private void gridControl3_MouseClick(object sender, MouseEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.Views[0] as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            view.SelectRow(hitInfo.RowHandle);

            if ((e.Button & MouseButtons.Left) != 0 &
                hitInfo.InRow &
                !view.IsGroupRow(hitInfo.RowHandle))
            {
                if (view.GetSelectedRows().Length == 1)
                {

                    Presenter.SetMovimentoScarico(
                        (VMovimentoGiacenza)view.GetRow(hitInfo.RowHandle));

                }
            }
        }
        #endregion

    }
}
