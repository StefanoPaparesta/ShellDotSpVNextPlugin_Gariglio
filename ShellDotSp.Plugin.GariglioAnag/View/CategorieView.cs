using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GarigliaAnag.Forms;
using ShellDotSp.Plugin.GariglioAnag.Presenters;
using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioCore.Model;

namespace ShellDotSp.Plugin.GariglioAnag.View
    {
    public partial class CategorieView : UserControl, ILocalView
        {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Ctor
        public CategorieView(MainPresenter Presenter)
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
            Presenter.CategoriaSelezionata = null;
            Presenter.LoadCategorie();
            }

        public void UpdateUI(string functionName)
            {
            switch (functionName)
                {
                case "listaCategorie":
                    bndCategorie.DataSource = Presenter.Categorie;
                    break;
                case "categoriaSelezionata":
                    btnCancella.Enabled = Presenter.CategoriaSelezionata != null;
                    btnModifica.Enabled = Presenter.CategoriaSelezionata != null;
                    break;
                default:
                    break;
                }
            }

        private void BtnAggiungi_Click(object sender, System.EventArgs e)
            {
            using (FrmCategoria Frm =
           new FrmCategoria(null))
                {

                if (Frm.ShowDialog()
                    == DialogResult.OK)
                    {

                    Presenter.ManageCategoria(Frm.Model);
                    Presenter.CategoriaSelezionata = null;
                    Presenter.LoadCategorie();

                    }

                }
            }

        private void btnCancella_Click(object sender, System.EventArgs e)
            {
            if (MessageBox.Show("Cancello la riga selezionata ?",
             "Magazzino",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Information) == DialogResult.Yes
             )
                {

                Presenter.CancellaCategoria(Presenter.CategoriaSelezionata);
                Presenter.CategoriaSelezionata = null;
                Presenter.LoadCategorie();

                }
            }

        private void btnModifica_Click(object sender, System.EventArgs e)
            {
            using (FrmCategoria Frm =
            new FrmCategoria(Presenter.CategoriaSelezionata))
                {

                if (Frm.ShowDialog()
                    == DialogResult.OK)
                    {

                    Presenter.ManageCategoria(Frm.Model);
                    Presenter.CategoriaSelezionata = null;
                    Presenter.LoadCategorie();

                    }

                }
            }

        private void gridControl1_MouseClick_1(object sender, MouseEventArgs e)
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

                    Presenter.CategoriaSelezionata =
                        (Categoria)view.GetRow(hitInfo.RowHandle);

                    }
                }
            }
        #endregion


        }
    }
