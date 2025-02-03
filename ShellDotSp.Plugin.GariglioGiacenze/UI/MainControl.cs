using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioGiacenze.Forms;
using ShellDotSp.Plugin.GariglioGiacenze.Interfaces;
using ShellDotSp.Plugin.GariglioGiacenze.Presenters;

namespace ShellDotSp.Plugin.GariglioGiacenze.UI
{
    public partial class MainControlGariglioGiacenze : UserControl, IMainView
    {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Ctor
        public MainControlGariglioGiacenze()
        {
            InitializeComponent();
            Presenter = new MainPresenter(this);
        }
        #endregion

        #region Implements IMainView

        public string Caption { get; set; }

        private event EventHandler viewInitialized;
        private event EventHandler closeView;

        public event EventHandler CloseView
        {
            add { closeView += value; }
            remove { closeView -= value; }
        }
        public event EventHandler ViewInitialized
        {
            add { viewInitialized += value; }
            remove { viewInitialized -= value; }
        }

        private void InvokeViewInitialized(EventArgs e)
        {
            viewInitialized?.Invoke(this, e);
        }
        private void InvokeCloseView(EventArgs e)
        {
            closeView?.Invoke(this, e);
        }

        public void Finalizza()
        {
            InvokeCloseView(EventArgs.Empty);
        }

        public void Inizializza()
        {
            InvokeViewInitialized(EventArgs.Empty);
            Presenter.SetGiacenza(null);
        }

        public void UpdateUI(Function functionName)
        {
            switch (functionName)
            {
                case Function.ElencoGiacenze:
                    bndData.DataSource = Presenter.Giacenze;
                    break;
                case Function.GiacenzaSelezionata:
                    btnMovimentoRettifica.Enabled = Presenter.GiacenzaSelezionata != null;
                    break;
            }
        }


        #endregion

        #region UI

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog Dlg = new SaveFileDialog())
            {
                Dlg.Filter = "Excel files (*.xlsx)|*.xlsx";
                Dlg.FilterIndex = 1;
                Dlg.RestoreDirectory = true;
                Dlg.FileName = $"ExportGiacenza_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";


                if (Dlg.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.ExportToXlsx(Dlg.FileName);
                }

            }
        }


        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
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

                    Presenter.SetGiacenza((VGiacenza)view.GetRow(hitInfo.RowHandle));

                }
            }
        }

        private void btnMovimentoRettifica_Click(object sender, EventArgs e)
        {
            using (FrmRettifica Frm = new FrmRettifica(Presenter))
            {
                if (Frm.ShowDialog() == DialogResult.OK)
                {
                    Presenter.EseguiRettifica(Frm.QtaRettifica);
                }

                Presenter.SetGiacenza(null);

            }
        }
        #endregion


    }
}
