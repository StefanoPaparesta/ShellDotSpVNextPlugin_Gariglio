using System.Windows.Forms;
using ShellDotSp.Plugin.GariglioCore.Model;

namespace ShellDotSp.Plugin.GarigliaAnag.Forms
    {
    public partial class FrmCategoria : Form
        {

        #region Fields
        public Categoria Model { get; set; }
        #endregion

        #region Ctor
        public FrmCategoria(Categoria Model)
            {
            InitializeComponent();
            this.Model = Model;
            }
        #endregion

        #region UI
        private void FrmCategoria_Load(object sender, System.EventArgs e)
            {

            if (Model == null)
                {

                Model = new Categoria();

                }
            else
                {

                txDescrizione.Text = Model.Descrizione;
                txCodice.Text = Model.Codice;

                }

            }

        private void btnOK_Click(object sender, System.EventArgs e)
            {

            Model.Descrizione = txDescrizione.Text;
            Model.Codice = txCodice.Text;
            Model.Tipo = "ART";
            DialogResult = DialogResult.OK;
            Close();

            }

        private void btnCancel_Click(object sender, System.EventArgs e)
            {

            DialogResult = DialogResult.Cancel;
            Close();

            }
        #endregion



        }
    }
