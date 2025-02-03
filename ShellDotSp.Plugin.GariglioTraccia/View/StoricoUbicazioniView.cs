#region Using
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.View
{
    public partial class StoricoUbicazioniView : UserControl, ILocalView
    {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Ctor

        public StoricoUbicazioniView(MainPresenter Presenter)
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
            dateEditDal.DateTime = DateTime.Today.AddDays(-30);
            dateEditAl.DateTime = DateTime.Today;

            Presenter.LoadUbicazioniStorico(dateEditDal.DateTime, dateEditAl.DateTime);

            btnAggiungi.Enabled = false;
            btnModifica.Enabled = false;
        }

        public void UpdateUI(string functionName)
        {
            switch (functionName)
            {
                case "listaUbicazioniStorico":
                    bndData.DataSource = Presenter.UbicazioniStorico;
                    break;
                case "ubicazioneStoricoSel":
                    break;
                default:
                    break;
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

                }
            }
        }

        #endregion

        #region UI

        private void BtnModifica_Click(object sender, System.EventArgs e)
        {

        }

        private void btnFiltra_Click(object sender, System.EventArgs e)
        {
            Presenter.LoadUbicazioniStorico(dateEditDal.DateTime, dateEditAl.DateTime);
        }

        private void btnAggiungi_Click(object sender, System.EventArgs e)
        {

        }

        #endregion


    }
}
