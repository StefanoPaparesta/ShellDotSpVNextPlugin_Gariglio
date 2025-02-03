#region Using
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioAnag.Forms;
using ShellDotSp.Plugin.GariglioAnag.Presenters;
using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioCore.Model;
#endregion

namespace ShellDotSp.Plugin.GariglioAnag.View
    {
    public partial class AnagraficheView : UserControl, ILocalView
        {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Properties



        #endregion

        #region Ctor
        public AnagraficheView(MainPresenter Presenter)
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
            Presenter.AnagraficaSelezionata = null;
            Presenter.TipoAnagrafica = null;
            Presenter.LoadAnagrafiche();
            }

        public void UpdateUI(string functionName)
            {

            switch (functionName)
                {
                case "tipoAnagrafica":

                    BtnAggiungi.Enabled = !string.IsNullOrEmpty(Presenter.TipoAnagrafica);
                    Presenter.LoadAnagrafiche();

                    break;
                case "listaAnagrafiche":
                    bndAnagrafiche.Clear();
                    bndAnagrafiche.DataSource = Presenter.Anagrafiche;
                    break;
                case "anagraficaSelezionata":
                    btnCancella.Enabled = Presenter.AnagraficaSelezionata != null;
                    btnModifica.Enabled = Presenter.AnagraficaSelezionata != null;
                    break;
                default:
                    break;

                }


            }

        #endregion

        #region UI


        private void BtnModifica_Click(object sender, System.EventArgs e)
            {

            using (FrmAnagrafica Frm =
                new FrmAnagrafica(Presenter.AnagraficaSelezionata, Presenter.AnagraficaSelezionata.Tipo))
                {

                if (Frm.ShowDialog()
                    == DialogResult.OK)
                    {

                    Presenter.ManageAnagrafica(Frm.Model);
                    Presenter.AnagraficaSelezionata = null;
                    Presenter.LoadAnagrafiche();

                    }

                }

            }

        private void BtnCancella_Click(object sender, System.EventArgs e)
            {

            if (MessageBox.Show("Cancello la riga selezionata ?",
                "Magazzino",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes
                )
                {

                Presenter.CancellaAnagrafica(Presenter.AnagraficaSelezionata);
                Presenter.AnagraficaSelezionata = null;
                Presenter.LoadAnagrafiche();

                }

            }

        private void BtnAggiungi_Click(object sender, System.EventArgs e)
            {

            using (FrmAnagrafica Frm =
                new FrmAnagrafica(null, Presenter.TipoAnagrafica))
                {

                if (Frm.ShowDialog()
                    == DialogResult.OK)
                    {

                    Presenter.ManageAnagrafica(Frm.Model);
                    Presenter.AnagraficaSelezionata = null;
                    Presenter.LoadAnagrafiche();

                    }

                }

            }

        private void cmbTipo_SelectedIndexChanged(object sender, System.EventArgs e)
            {
            if (cmbTipo.SelectedIndex == -1)
                {
                Presenter.TipoAnagrafica = string.Empty;
                }

            if (cmbTipo.SelectedIndex == 0)
                {
                Presenter.TipoAnagrafica = "C";
                }

            if (cmbTipo.SelectedIndex == 1)
                {
                Presenter.TipoAnagrafica = "F";
                }

            }

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

                    Presenter.AnagraficaSelezionata =
                        (Anagrafica)view.GetRow(hitInfo.RowHandle);

                    }
                }
            }

        #endregion

        }
    }
