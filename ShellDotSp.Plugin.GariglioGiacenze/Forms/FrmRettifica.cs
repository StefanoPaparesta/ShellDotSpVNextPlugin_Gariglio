#region Using
using DevExpress.XtraEditors;

using DotSpExtensions.Winforms;

using ShellDotSp.Plugin.GariglioGiacenze.Presenters;

using System.Windows.Forms;
#endregion

namespace ShellDotSp.Plugin.GariglioGiacenze.Forms
{
    public partial class FrmRettifica : XtraForm
    {

        #region Fields
        private MainPresenter Presenter;
        private MsgBoxHelper Msg = new MsgBoxHelper(Properties.Resources.MsgTitolo);
        #endregion

        #region Properties
        public decimal QtaRettifica { get; set; }
        #endregion

        #region Ctor
        public FrmRettifica(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region Action
        private void FrmRettifica_Load(object sender, System.EventArgs e)
        {

            if (Presenter.GiacenzaSelezionata.Giacenza > 0)
            {
                txQtaRettifica.Text = (-Presenter.GiacenzaSelezionata.Giacenza).ToString("f3");
            }
            else
            {
                txQtaRettifica.Text = (Presenter.GiacenzaSelezionata.Giacenza * -1).ToString("f3");
            }

            lblInfo.Text = Presenter.GiacenzaSelezionata.Descrizione + " " + Presenter.GiacenzaSelezionata.Lotto;

            Clipboard.SetText(Presenter.GiacenzaSelezionata.IdArticolo + "\t" +
                Presenter.GiacenzaSelezionata.Descrizione + "\t" +
                Presenter.GiacenzaSelezionata.Lotto);

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {

            if (Msg.Question("Eseguo la rettifica di magazzino ?") == DialogResult.Yes)
            {
                QtaRettifica = decimal.Parse(txQtaRettifica.Text);
                DialogResult = DialogResult.OK;
            }

        }
        #endregion

    }
}
