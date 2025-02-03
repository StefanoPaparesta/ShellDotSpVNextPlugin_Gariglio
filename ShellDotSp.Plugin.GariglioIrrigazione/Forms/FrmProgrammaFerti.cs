#region Using
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioIrrigazione.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioIrrigazione.Forms
{
    public partial class FrmProgrammaFerti : Form
    {

        #region Fields
        private MainPresenter Presenter;
        #endregion

        #region Properties
        public ProgIrrigazione ProgrammaSelezionato { get; set; }
        #endregion

        #region Ctor
        public FrmProgrammaFerti(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region UI
        private void FrmProgrammaFerti_Load(object sender, System.EventArgs e)
        {

            txCodice.Focus();

            if (ProgrammaSelezionato == null)
            {

                ProgrammaSelezionato = new ProgIrrigazione();

            }
            else
            {

                txCodice.Text = ProgrammaSelezionato.CodiceProgramma;
                txDescrizione.Text = ProgrammaSelezionato.Descrizione;
                txPartiA.Text = ProgrammaSelezionato.PartiA.ToString();
                txPartiB.Text = ProgrammaSelezionato.PartiB.ToString();
                txPartiC.Text = ProgrammaSelezionato.PartiC.ToString();
                txPartiD.Text = ProgrammaSelezionato.PartiD.ToString();
                txConducibilita.Text = ProgrammaSelezionato.Conducibilita.ToString();
                txPh.Text = ProgrammaSelezionato.Ph.ToString();
                txAperturaEvPh.Text = ProgrammaSelezionato.AperturaEVPh.ToString();
                txEV1.Text = ProgrammaSelezionato.Ev1.ToString();
                txEV2.Text = ProgrammaSelezionato.Ev2.ToString();
                txEV3.Text = ProgrammaSelezionato.Ev3.ToString();
                txEV4.Text = ProgrammaSelezionato.Ev4.ToString();
                txEV5.Text = ProgrammaSelezionato.Ev5.ToString();
                txEV6.Text = ProgrammaSelezionato.Ev6.ToString();
                txDurata.Text = ProgrammaSelezionato.Durata.ToString();

                if (ProgrammaSelezionato.DataInizioUtilizzo.HasValue)
                {
                    dataInizioUtilizzo.DateTime = ProgrammaSelezionato.DataInizioUtilizzo.Value;
                }

                if (ProgrammaSelezionato.DataFineUtilizzo.HasValue)
                {
                    dataFineUtilizzo.DateTime = ProgrammaSelezionato.DataFineUtilizzo.Value;
                }

            }

        }
        private void btnOK_Click(object sender, System.EventArgs e)
        {

            List<string> ErrorMessages = VerificaTestata();

            if (ErrorMessages.Count == 0)
            {

                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {

                string msg = string.Join("\r\n", ErrorMessages);

                MessageBox.Show(msg,
                    "Gariglio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }

        private List<string> VerificaTestata()
        {

            ProgrammaSelezionato.CodiceProgramma = txCodice.Text;
            ProgrammaSelezionato.Descrizione = txDescrizione.Text;
            ProgrammaSelezionato.PartiA = int.Parse(txPartiA.Text);
            ProgrammaSelezionato.PartiB = int.Parse(txPartiB.Text);
            ProgrammaSelezionato.PartiC = int.Parse(txPartiC.Text);
            ProgrammaSelezionato.PartiD = int.Parse(txPartiD.Text);
            ProgrammaSelezionato.Conducibilita = decimal.Parse(txConducibilita.Text);
            ProgrammaSelezionato.Ph = decimal.Parse(txPh.Text);
            ProgrammaSelezionato.AperturaEVPh = int.Parse(txAperturaEvPh.Text);
            ProgrammaSelezionato.Ev1 = int.Parse(txEV1.Text);
            ProgrammaSelezionato.Ev2 = int.Parse(txEV2.Text);
            ProgrammaSelezionato.Ev3 = int.Parse(txEV3.Text);
            ProgrammaSelezionato.Ev4 = int.Parse(txEV4.Text);
            ProgrammaSelezionato.Ev5 = int.Parse(txEV5.Text);
            ProgrammaSelezionato.Ev6 = int.Parse(txEV6.Text);
            ProgrammaSelezionato.Durata = int.Parse(txDurata.Text);

            if (dataInizioUtilizzo.DateTime != DateTime.MinValue)
            {
                ProgrammaSelezionato.DataInizioUtilizzo = dataInizioUtilizzo.DateTime;
            }
            else
            {
                ProgrammaSelezionato.DataInizioUtilizzo = null;
            }

            if (dataFineUtilizzo.DateTime != DateTime.MinValue)
            {
                ProgrammaSelezionato.DataFineUtilizzo = dataFineUtilizzo.DateTime;
            }
            else
            {
                ProgrammaSelezionato.DataFineUtilizzo = null;
            }

            List<string> ErrorMessages = new List<string>();

            if (string.IsNullOrEmpty(ProgrammaSelezionato.CodiceProgramma))
            {
                errorProvider1.SetError(txCodice, "Dato obbligatorio!!");
                ErrorMessages.Add("Codice programma obbligatorio");
            }
            else
            {
                errorProvider1.SetError(txCodice, "");
            }
            if (string.IsNullOrEmpty(ProgrammaSelezionato.Descrizione))
            {
                errorProvider1.SetError(txDescrizione, "Dato obbligatorio!!");
                ErrorMessages.Add("Descrizione programma obbligatorio");
            }
            else
            {
                errorProvider1.SetError(txDescrizione, "");
            }

            return ErrorMessages;

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        #endregion

    }
}
