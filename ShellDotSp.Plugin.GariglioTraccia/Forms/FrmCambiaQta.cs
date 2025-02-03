using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;

namespace ShellDotSp.Plugin.GariglioTraccia.Forms
{
    public partial class FrmCambiaQta : XtraForm
    {

        #region Fields

        private MainPresenter Presenter;
        public Movimento MovimentoSelezionato { get; set; }
        #endregion

        #region Ctor
        public FrmCambiaQta(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region UI
        private void FrmCambiaQta_Load(object sender, System.EventArgs e)
        {
            switch (MovimentoSelezionato)
            {
                case Movimento.Carico:

                    txQta.Text = Presenter.MovimentoCarico.Qta.ToString("f0");
                    txQtaPrecedente.Text = Presenter.MovimentoCarico.QtaPrecedente.ToString("f0");
                    lblTipoMovimento.Text = "CARICO";
                    lblUbicazione.Text = $"{Presenter.MovimentoCarico.Ubicazione}/{Presenter.MovimentoCarico.Lotto} {Presenter.MovimentoCarico.Causale}";
                    break;

                case Movimento.Scarico:

                    txQta.Text = Presenter.MovimentoScarico.Qta.ToString("f0");
                    txQtaPrecedente.Text = Presenter.MovimentoScarico.QtaPrecedente.ToString("f0");
                    lblTipoMovimento.Text = "SCARICO";
                    lblUbicazione.Text = $"{Presenter.MovimentoScarico.Ubicazione}/{Presenter.MovimentoScarico.Lotto} {Presenter.MovimentoScarico.Causale}";
                    break;

            }

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {

            switch (MovimentoSelezionato)
            {
                case Movimento.Carico:

                    Presenter.MovimentoCarico.Qta = decimal.Parse(txQta.Text);
                    Presenter.MovimentoCarico.QtaPrecedente = decimal.Parse(txQtaPrecedente.Text);
                    Presenter.SalvaMovimento(Presenter.MovimentoCarico);

                    break;

                case Movimento.Scarico:

                    Presenter.MovimentoScarico.Qta = decimal.Parse(txQta.Text);
                    Presenter.MovimentoScarico.QtaPrecedente = decimal.Parse(txQtaPrecedente.Text);
                    Presenter.SalvaMovimento(Presenter.MovimentoScarico);

                    break;

            }

            DialogResult = DialogResult.OK;

        }

        #endregion


    }
}
