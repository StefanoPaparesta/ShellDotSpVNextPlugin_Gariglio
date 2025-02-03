#region Using
using DotSpExtensions;

using ShellDotSp.Plugin.GariglioAnag.Presenters;
using ShellDotSp.Plugin.GariglioCore.Model;

using System.Windows.Forms;
#endregion

namespace ShellDotSp.Plugin.GariglioAnag.Forms
{
    public partial class FrmArticolo : Form
    {

        #region Fields
        public VArticolo Model { get; set; }
        public Articolo ModelNew { get; set; }
        private MainPresenter Presenter;
        #endregion

        #region Ctor
        public FrmArticolo(VArticolo Model, MainPresenter Presenter)
        {
            InitializeComponent();
            this.Model = Model;
            this.Presenter = Presenter;
        }
        #endregion

        #region UI

        private void FrmAnagrafica_Load(object sender, System.EventArgs e)
        {

            Presenter.LoadCategorie();
            bndCategorie.DataSource = Presenter.Categorie;

            bndUmVendita.DataSource = Presenter.LoadUm(Tipo: 1);
            bndUmDosaggio.DataSource = Presenter.LoadUm(Tipo: 2);

            ModelNew = new Articolo();

            if (Model == null)
            {

                txDiluizione.Text = "100";

            }
            else
            {

                ModelNew.Id = Model.Id;

                txDescrizione.Text = Model.DescrizioneArticolo;

                lkUmVendita.EditValue = Model.Um;
                lkUmDosaggio.EditValue = Model.UmDiluizione;

                txDiluizione.Text = Model.QtaRifDiluizione.ToString("f0");
                txQtaDiluizione.Text = Model.Diluizione.ToString("f0");
                txNote.Text = Model.Note;
                lkCategoria.EditValue = Model.Categoria;
                txCodiceArticoloFor.Text = Model.CodiceArticoloFor;
                txClassificazionePericolo.Text = Model.ClassificazionePericolo;
                txMotivoTrattamento.Text = Model.MotivoTrattamento;

            }


        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {

            ModelNew.Descrizione = txDescrizione.Text.ToDb();
            //Model.Um = txUm.Text.ToDb(); 

            var UmVendita = (UnitaMisura)lkUmVendita.GetSelectedDataRow();
            var UmDosaggio = (UnitaMisura)lkUmDosaggio.GetSelectedDataRow();

            ModelNew.Um = UmVendita?.Codice;
            ModelNew.UmDiluizione = UmDosaggio?.Codice;

            ModelNew.Diluizione = decimal.Parse(txQtaDiluizione.Text.Replace(".", ","));
            ModelNew.QtaRifDiluizione = decimal.Parse(txDiluizione.Text.Replace(".", ","));
            ModelNew.CodiceArticoloFor = txCodiceArticoloFor.Text.ToDb();
            ModelNew.MotivoTrattamento = txMotivoTrattamento.Text;
            ModelNew.ClassificazionePericolo = txClassificazionePericolo.Text;

            if (lkCategoria.EditValue != null)
            {
                ModelNew.Categoria = lkCategoria.EditValue.ToString();
            }
            ModelNew.Note = txNote.Text.ToDb();

            DialogResult = DialogResult.OK;
            Close();

        }

        #endregion

    }
}
