#region Using
using System;
using System.IO;
using System.Windows.Forms;
using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.View
{
    public partial class ReportView : UserControl, ILocalView
    {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Ctor

        public ReportView(MainPresenter Presenter)
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

            dateEditDal.Enabled = false;
            dateEditAl.Enabled = false;
            btnStampa.Enabled = false;
            btnEsporta.Enabled = false;

            if (File.Exists("VenditePivotGrid.xml"))
            {
                pivotGridControl1.RestoreLayoutFromXml("VenditePivotGrid.xml");
            }

        }

        public void UpdateUI(string functionName)
        {
            switch (functionName)
            {
                case "StatsPivotVendita":

                    if (Presenter.ElencoStatsVendita.Count == 0)
                    {
                        bndPivot.Clear();
                    }
                    else
                    {
                        bndPivot.DataSource = Presenter.ElencoStatsVendita;
                    }

                    break;
                default:
                    break;
            }
        }


        #endregion

        #region UI

        private void cmbReport_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            VerificaCanExecute();

            if (cmbReport.SelectedIndex >= 0)
            {
                dateEditDal.Enabled = true;
                dateEditAl.Enabled = true;
            }


        }

        private void btnStampa_Click(object sender, System.EventArgs e)
        {

            Presenter.GeneraReport(cmbReport.SelectedIndex);

            if (cmbReport.SelectedIndex == 9)
            {
                pivotGridControl1.SaveLayoutToXml("VenditePivotGrid.xml");
            }

        }

        private void dateEditDal_EditValueChanged(object sender, System.EventArgs e)
        {

            Presenter.ReportDal = dateEditDal.DateTime;

            var DaysInMonth = DateTime.DaysInMonth(Presenter.ReportDal.Year, Presenter.ReportDal.Month);

            dateEditAl.DateTime = new DateTime(Presenter.ReportDal.Year,
                Presenter.ReportDal.Month,
                DaysInMonth);

            VerificaCanExecute();

        }

        private void dateEditAl_EditValueChanged(object sender, System.EventArgs e)
        {

            Presenter.ReportAl = dateEditAl.DateTime;
            VerificaCanExecute();

        }

        private void VerificaCanExecute()
        {
            if (Presenter.ReportDal != DateTime.MinValue && Presenter.ReportAl != DateTime.MinValue)
            {
                btnStampa.Enabled = true;
                btnEsporta.Enabled = cmbReport.SelectedIndex != -1;
            }
            else
            {
                btnStampa.Enabled = false;
                btnEsporta.Enabled = false;
            }
        }

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog Dlg = new SaveFileDialog())
                {
                    Dlg.Filter = "Excel files (*.xlsx)|*.xlsx";
                    Dlg.FilterIndex = 1;
                    Dlg.RestoreDirectory = true;

                    if (cmbReport.SelectedIndex == 9)
                    {

                        Dlg.FileName = $"ExportPivotVendite_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";

                        if (Dlg.ShowDialog() == DialogResult.OK)
                        {
                            pivotGridControl1.ExportToXlsx(Dlg.FileName);
                        }

                    }
                    else
                    {

                        switch (cmbReport.SelectedIndex)
                        {
                            case 0:
                                Dlg.FileName = $"ExportAcquisti_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 1:
                                Dlg.FileName = $"ExportVendite_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 2:
                                Dlg.FileName = $"ExportElencoIrrigazioni_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 3:
                                Dlg.FileName = $"ExportSemine_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 4:
                                Dlg.FileName = $"ExportCaricoTaniche_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 5:
                                Dlg.FileName = $"ExportPivotQC_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 6:
                                Dlg.FileName = $"ExportGiacenze_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 7:
                                Dlg.FileName = $"ExportBilancioMassa_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;
                            case 8:
                                Dlg.FileName = $"ExportTorba_{DateTime.Now:ddMMyyyy_HHmmss}.xlsx";
                                break;

                        }
                        if (Dlg.ShowDialog() == DialogResult.OK)
                        {
                            Presenter.GeneraXls(cmbReport.SelectedIndex, Dlg.FileName);
                        }
                    }


                    MessageBox.Show("Esportazione eseguita!",
                                   "Gariglio",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                    "Gariglio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
