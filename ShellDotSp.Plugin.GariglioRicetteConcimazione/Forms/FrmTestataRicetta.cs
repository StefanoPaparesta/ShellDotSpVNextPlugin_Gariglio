#region Using
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioRicetteConcimazione.Forms
    {
    public partial class FrmTestataRicetta : Form
        {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Properties

        public RicettaIrrigazioneTestata Ricetta { get; set; }

        #endregion

        #region Ctor

        public FrmTestataRicetta(MainPresenter Presenter)
            {
            InitializeComponent();
            this.Presenter = Presenter;
            }

        #endregion

        #region UI

        private void FrmTestataRicetta_Load(object sender, System.EventArgs e)
            {

            if (Ricetta == null)
                {
                Ricetta = new RicettaIrrigazioneTestata();
                }
            else
                {
                txDescrizione.Text = Ricetta.Descrizione;

                if (Ricetta.DataInizioUtilizzo.HasValue)
                    {
                    dataInizioUtilizzo.DateTime = Ricetta.DataInizioUtilizzo.Value;
                    }
                else
                    {
                    dataInizioUtilizzo.EditValue = null;
                    }


                if (Ricetta.DataFineUtilizzo.HasValue)
                    {
                    dataFineUtilizzo.DateTime = Ricetta.DataFineUtilizzo.Value;
                    }
                else
                    {
                    dataFineUtilizzo.EditValue = null;
                    }

                }

            }

        private void btnOK_Click(object sender, System.EventArgs e)
            {

            var errors = VerificaDati();

            if (errors.Count == 0)
                {

                DialogResult = DialogResult.OK;
                Close();

                }
            else
                {

                string msg = string.Join("\r\n", errors);

                MessageBox.Show(msg,
                "Gariglio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                }

            }

        private void btnCancel_Click(object sender, System.EventArgs e)
            {
            DialogResult = DialogResult.Cancel;
            Close();
            }

        private List<string> VerificaDati()
            {

            List<string> ret = new List<string>();

            Ricetta.Descrizione = txDescrizione.Text;

            if (dataInizioUtilizzo.DateTime == DateTime.MinValue)
                {
                Ricetta.DataInizioUtilizzo = null;
                }
            else
                {
                Ricetta.DataInizioUtilizzo = dataInizioUtilizzo.DateTime;
                }

            if (dataFineUtilizzo.DateTime == DateTime.MinValue)
                {
                Ricetta.DataFineUtilizzo = null;
                }
            else
                {
                Ricetta.DataFineUtilizzo = dataFineUtilizzo.DateTime;
                }

            if (string.IsNullOrEmpty(Ricetta.Descrizione))
                {

                ret.Add("Descrizione Dato obbligatorio");
                errorProvider1.SetError(txDescrizione, "Dato obbligatorio");

                }
            else
                {

                errorProvider1.SetError(txDescrizione, "");


                }

            if (Ricetta.DataInizioUtilizzo == null)
                {

                ret.Add("DataInizioUtilizzo Dato obbligatorio");
                errorProvider1.SetError(dataInizioUtilizzo, "Dato obbligatorio");

                }
            else
                {

                errorProvider1.SetError(dataInizioUtilizzo, "");


                }

            return ret;

            }

        #endregion

        }
    }
