using DotSpExtensions;

using ShellDotSp.Plugin.GariglioCore.Model;

using System.Windows.Forms;

namespace ShellDotSp.Plugin.GariglioAnag.Forms
{
    public partial class FrmAnagrafica : Form
    {

        #region Fields
        public Anagrafica Model { get; set; }
        private string Tipo;
        #endregion

        #region Ctor
        public FrmAnagrafica(Anagrafica Model, string Tipo)
        {
            InitializeComponent();
            this.Model = Model;
            this.Tipo = Tipo;
        }
        #endregion

        #region UI
        private void FrmAnagrafica_Load(object sender, System.EventArgs e)
        {


            if (Model == null)
            {

                Model = new Anagrafica();
                Model.Tipo = Tipo;

            }
            else
            {

                txPartitaIva.Text = Model.PartitaIva;
                txCodiceFiscale.Text = Model.CodiceFiscale;

                txIndirizzo.Text = Model.Indirizzo;
                txLocalita.Text = Model.Localita;
                txProvincia.Text = Model.Provincia;
                txRagioneSociale.Text = Model.RagioneSociale;
                txCap.Text = Model.Cap;

            }


        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {

            DialogResult = DialogResult.OK;

            Model.PartitaIva = txPartitaIva.Text.ToDb();
            Model.CodiceFiscale = txCodiceFiscale.Text.ToDb();
            Model.RagioneSociale = txRagioneSociale.Text.ToDb();
            Model.Indirizzo = txIndirizzo.Text;
            Model.Localita = txLocalita.Text;
            Model.Provincia = txProvincia.Text;
            Model.Cap = txCap.Text;

            if (string.IsNullOrEmpty(Model.PartitaIva))
            {

                MessageBox.Show("Partita Iva obbligatoria",
                    "Gariglio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }
        #endregion

    }
}
