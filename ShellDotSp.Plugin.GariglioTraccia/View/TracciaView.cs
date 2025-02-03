#region Using
using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;
using System.Windows.Forms;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.View
{
    public partial class TracciaView : UserControl, ILocalView
    {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Properties

        #endregion

        #region Ctor

        public TracciaView(MainPresenter Presenter)
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
            btnExport.Enabled = false;
        }

        public void UpdateUI(string functionName)
        {

            switch (functionName)
            {

                case "listaTraccia":

                    if (Presenter.ElencoTracciabilita.Count == 0)
                    {
                        bndData.Clear();
                        btnExport.Enabled = false;
                    }
                    else
                    {
                        bndData.DataSource = Presenter.ElencoTracciabilita;
                        btnExport.Enabled = true;
                    }
                    break;
                case "listaTracciaDocVendita":

                    if (Presenter.ElencoTracciabilitaDocVendita.Count == 0)
                    {
                        bndDocVendita.Clear();
                        btnExport.Enabled = false;
                    }
                    else
                    {
                        bndDocVendita.DataSource = Presenter.ElencoTracciabilitaDocVendita;
                        btnExport.Enabled = true;
                    }
                    break;
                case "listaTracciaConf":

                    if (Presenter.ElencoTracciabilitaConf.Count == 0)
                    {
                        bndUbicazioni.Clear();
                        btnExport.Enabled = false;
                    }
                    else
                    {
                        bndUbicazioni.DataSource = Presenter.ElencoTracciabilitaConf;
                        btnExport.Enabled = true;
                    }
                    break;

            }

        }

        #endregion

        #region UI

        private void btnFiltra_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txLotto.Text))
            {
                MessageBox.Show("LOTTO non inserito",
               "Magazzino",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information);
            }
            else
            {
                Presenter.LoadTracciabilita(txLotto.Text);
                Presenter.LoadTracciabilitaDocVendita(txLotto.Text);
                Presenter.LoadTracciabilitaConf(txLotto.Text);
            }

        }

        private void GridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //GridControl grid = sender as GridControl;
            //GridView view = grid.Views[0] as GridView;
            //GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            //view.SelectRow(hitInfo.RowHandle);

            //if ((e.Button & MouseButtons.Left) != 0 &
            //    hitInfo.InRow &
            //    !view.IsGroupRow(hitInfo.RowHandle))
            //{
            //    if (view.GetSelectedRows().Length == 1)
            //    {

            //        VTracciaTestata Testata
            //            = (VTracciaTestata)view.GetRow(view.GetSelectedRows()[0]);
            //        Presenter.SetTestataTraccia(Testata);

            //    }
            //}
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(txLotto.Text))
            {
                MessageBox.Show("LOTTO non inserito",
               "Magazzino",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information);

                return;
            }

            string idx = tabPane1.SelectedPage.Tag.ToString();
            string fileName = string.Empty;

            switch (idx)
            {

                case "0":
                    fileName = $"Tracciabilita_LottoConf_{txLotto.Text}.xlsx";
                    break;
                case "1":
                    fileName = $"DocVendita_LottoConf_{txLotto.Text}.xlsx";
                    break;
                case "2":
                    fileName = $"Confezionamento_LottoConf_{txLotto.Text}.xlsx";
                    break;

            }

            using (SaveFileDialog Dlg = new SaveFileDialog())
            {

                Dlg.Filter = "Excel files (*.xlsx)|*.xlsx";
                Dlg.FilterIndex = 1;
                Dlg.RestoreDirectory = true;
                Dlg.FileName = fileName;


                if (Dlg.ShowDialog() == DialogResult.OK)
                {

                    if (idx == "0")
                    {
                        gridControl1.ExportToXlsx(Dlg.FileName);
                    }
                    if (idx == "1")
                    {
                        gridControl2.ExportToXlsx(Dlg.FileName);
                    }
                    if (idx == "2")
                    {
                        gridControl3.ExportToXlsx(Dlg.FileName);
                    }

                }

            }
        }

        #endregion

    }
}
