#region Using
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.Forms
{
    public partial class FrmModificaMP : XtraForm
    {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Ctor
        public FrmModificaMP(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region UI

        private void FrmModificaMP_Load(object sender, System.EventArgs e)
        {
            if (Presenter.TracciaMPSelezionata != null)
            {
                txQta.Text = Presenter.TracciaMPSelezionata.Qta.ToString("f3");
            }
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {

            Presenter.TracciaMPSelezionata.Qta = decimal.Parse(txQta.Text);
            DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion


    }
}
