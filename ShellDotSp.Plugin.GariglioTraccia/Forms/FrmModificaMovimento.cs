#region Using
using DevExpress.XtraEditors;

using DotSpExtensions;

using ShellDotSp.Plugin.GariglioTraccia.Presenters;

using System.Windows.Forms;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.Forms
{
    public partial class FrmModificaMovimento : XtraForm
    {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Ctor
        public FrmModificaMovimento(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region UI
        private void FrmModificaMovimento_Load(object sender, System.EventArgs e)
        {

            if (Presenter.MovimentoDettaglioSelezionato != null)
            {

                txCausale.Text = Presenter.MovimentoDettaglioSelezionato.Causale;
                txLotto.Text = Presenter.MovimentoDettaglioSelezionato.Lotto;
                txLottoOrigine.Text = Presenter.MovimentoDettaglioSelezionato.LottoOrigine;
                txQta.Text = Presenter.MovimentoDettaglioSelezionato.Qta.ToString("f3");
                txQtaPrec.Text = Presenter.MovimentoDettaglioSelezionato.QtaPrecedente.ToString("f3");
                txFormatoConf.Text = Presenter.MovimentoDettaglioSelezionato.FormatoConf;
                txUbicazione.Text = Presenter.MovimentoDettaglioSelezionato.Ubicazione;
                txUbicazionePrec.Text = Presenter.MovimentoDettaglioSelezionato.UbicazionePrecedente;

            }

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {

            Presenter.MovimentoDettaglioSelezionato.Lotto = txLotto.Text.ToDb();
            Presenter.MovimentoDettaglioSelezionato.LottoOrigine = txLottoOrigine.Text.ToDb();
            Presenter.MovimentoDettaglioSelezionato.Qta = decimal.Parse(txQta.Text);
            Presenter.MovimentoDettaglioSelezionato.QtaPrecedente = decimal.Parse(txQtaPrec.Text);
            Presenter.MovimentoDettaglioSelezionato.FormatoConf = txFormatoConf.Text.ToDb();
            Presenter.MovimentoDettaglioSelezionato.Ubicazione = txUbicazione.Text.ToDb();
            Presenter.MovimentoDettaglioSelezionato.UbicazionePrecedente = txUbicazionePrec.Text.ToDb();

            DialogResult = DialogResult.OK;

        }
        #endregion


    }
}
