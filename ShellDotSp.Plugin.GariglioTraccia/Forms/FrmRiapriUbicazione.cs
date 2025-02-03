#region Using
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.Forms
{
    public partial class FrmRiapriUbicazione : XtraForm
    {

        #region Fields

        private MainPresenter Presenter;
        private List<UbicazioneStorico> UbicazioniStorico;

        #endregion

        #region Properties
        public UbicazioneStorico UbicazioneStoricoSelezionato { get; set; }
        #endregion

        #region Ctor
        public FrmRiapriUbicazione(MainPresenter Presenter)
        {

            InitializeComponent();
            this.Presenter = Presenter;

        }
        #endregion

        #region Using

        private void FrmRiapriUbicazione_Load(object sender, System.EventArgs e)
        {

            if (Presenter.UbicazioneSelezionata != null)
            {

                lblUbicazione.Text = Presenter.UbicazioneSelezionata.Codice;

                UbicazioniStorico = Presenter.GetUbicazioniStoricoRiapri();

                if (UbicazioniStorico.Count > 1 | UbicazioniStorico.Count == 0)
                {

                    lblStoricoUbicazione.Text = "ERRORE LOAD STORICO";
                    lblStoricoUbicazione.BackColor = Color.Red;
                    lblStoricoUbicazione.ForeColor = Color.White;

                }
                else
                {

                    lblStoricoUbicazione.Text = "Dati Ultima Ubicazione";

                    UbicazioneStoricoSelezionato = UbicazioniStorico[0];

                    lblStoricoUbicazione.BackColor = SystemColors.Control;
                    lblStoricoUbicazione.ForeColor = SystemColors.ControlText;

                    lblDataApertura.Text = UbicazioneStoricoSelezionato.DataCreazione.ToString("dd/MM/yy HH:mm");
                    lblDataChiusura.Text = UbicazioneStoricoSelezionato.DataChiusura.Value.ToString("dd/MM/yy HH:mm");
                    lblLotto.Text = UbicazioneStoricoSelezionato.Lotto;

                }

            }

        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion

    }
}
