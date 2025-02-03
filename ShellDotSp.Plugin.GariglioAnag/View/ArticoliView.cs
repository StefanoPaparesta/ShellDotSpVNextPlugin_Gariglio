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
    public partial class ArticoliView : UserControl, ILocalView
    {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Ctor
        public ArticoliView(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region Implements ILocalView
        public void OnFinalize()
        {
        }

        public void OnInit()
        {
            Presenter.ArticoloSelezionato = null;
            Presenter.LoadArticoli();
        }

        public void UpdateUI(string functionName)
        {
            switch (functionName)
            {
                case "listaArticoli":
                    bndArticoli.DataSource = Presenter.Articoli;
                    break;
                case "articoloSelezionato":
                    btnCancella.Enabled = Presenter.ArticoloSelezionato != null;
                    btnModifica.Enabled = Presenter.ArticoloSelezionato != null;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region UI

        private void BtnModifica_Click(object sender, System.EventArgs e)
        {
            using (FrmArticolo Frm =
             new FrmArticolo(Presenter.ArticoloSelezionato, Presenter))
            {

                if (Frm.ShowDialog()
                    == DialogResult.OK)
                {

                    Presenter.ManageArticoli(Frm.ModelNew);
                    Presenter.ArticoloSelezionato = null;
                    Presenter.LoadArticoli();

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

                Presenter.CancellaArticoli(Presenter.ArticoloSelezionato);
                Presenter.ArticoloSelezionato = null;
                Presenter.LoadArticoli();

            }
        }

        private void BtnAggiungi_Click(object sender, System.EventArgs e)
        {
            using (FrmArticolo Frm =
            new FrmArticolo(null, Presenter))
            {

                if (Frm.ShowDialog()
                    == DialogResult.OK)
                {

                    Presenter.ManageArticoli(Frm.ModelNew);
                    Presenter.ArticoloSelezionato = null;
                    Presenter.LoadArticoli();

                }

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

                    Presenter.ArticoloSelezionato =
                        (VArticolo)view.GetRow(hitInfo.RowHandle);

                }
            }
        }
        #endregion



    }
}
