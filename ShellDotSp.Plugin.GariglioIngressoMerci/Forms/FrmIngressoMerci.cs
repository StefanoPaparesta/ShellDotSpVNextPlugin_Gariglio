#region Using
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using DotSpExtensions;

using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioIngressoMerci.Presenters;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
#endregion

namespace ShellDotSp.Plugin.GariglioIngressoMerci.Forms
{
    public partial class FrmIngressoMerci : Form
    {

        #region Ctor
        public FrmIngressoMerci(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region Fields

        private MainPresenter Presenter;
        private Articolo _ArticoloSelezionato;
        private DocumentoRiga _RigaSelezionata;

        #endregion

        #region Properties

        public Articolo ArticoloSelezionato
        {
            get { return _ArticoloSelezionato; }
            set
            {
                _ArticoloSelezionato = value;
                VerificaRigaArticolo();
            }
        }
        public DocumentoRiga RigaSelezionata
        {
            get { return _RigaSelezionata; }
            set
            {
                _RigaSelezionata = value;
                btnCancellaArticolo.Enabled = _RigaSelezionata != null;
            }
        }
        public Anagrafica Cliente { get; set; }
        public DateTime DataDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public DocumentoTestata Documento { get; set; }

        #endregion

        #region UI

        private void FrmIngressoMerci_Load(object sender, System.EventArgs e)
        {

            Presenter.LoadAnagrafiche("F");
            Presenter.LoadArticoli();

            bndFornitori.DataSource = Presenter.Fornitori;
            bndArticoli.DataSource = Presenter.Articoli;

            if (Presenter.DocumentoSelezionato == null)
            {

                Documento = new DocumentoTestata()
                {
                    DataDocumento = DateTime.Today
                };

            }
            else
            {

                Documento = new DocumentoTestata()
                {
                    Id = Presenter.DocumentoSelezionato.IdTestata,
                    Tipo = Presenter.DocumentoSelezionato.TipoDocumento,
                    DataDocumento = Presenter.DocumentoSelezionato.DataDocumento,
                    IdAnagrafica = Presenter.DocumentoSelezionato.IdAnagrafica,
                    Numero = Presenter.DocumentoSelezionato.NumeroDocumento
                };

            }


            if (Presenter.DocumentoSelezionato != null &&
                Presenter.DocumentoSelezionato.IdTestata != 0)
            {
                Documento.Dettaglio = Presenter.LoadRighe(Presenter.DocumentoSelezionato.IdTestata);
            }

            bndRighe.DataSource = Documento.Dettaglio;

            txNumeroDocumento.Text = Documento.Numero;
            lkCliente.EditValue = Documento.IdAnagrafica;
            dataDocumento.DateTime = Documento.DataDocumento;

            RigaSelezionata = null;
            VerificaRigaArticolo();

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnOK_Click(object sender, System.EventArgs e)
        {

            NumeroDocumento = txNumeroDocumento.Text;

            List<string> ErrorMessages = VerificaTestata();

            if (ErrorMessages.Count == 0)
            {


                Documento.DataDocumento = DataDocumento;
                Documento.IdAnagrafica = Cliente.Id;
                Documento.Numero = NumeroDocumento;
                Documento.Tipo = "BEM";


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
        private void btnAggiungiArticolo_Click(object sender, System.EventArgs e)
        {
            bool response = false;

            int num = (from x in Documento.Dettaglio
                       where x.IdArticolo == ArticoloSelezionato.Id
                       select x).Count();

            if (num > 0)
            {

                if (MessageBox.Show("Articolo già presente, lo carico comunque ?",
                                    "Gariglio",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    response = true;
                }

            }
            else
            {
                response = true;
            }

            if (response)
            {

                DocumentoRiga riga = new DocumentoRiga();

                if (Presenter.DocumentoSelezionato != null)
                {
                    riga.IdTestata = Presenter.DocumentoSelezionato.IdTestata;
                }

                riga.IdArticolo = ArticoloSelezionato.Id;
                riga.Qta = decimal.Parse(txQta.Text.Replace(".", ","));
                riga.Um = ArticoloSelezionato.Um;
                riga.Lotto = txLotto.Text.ToDb();
                riga.PrezzoAcquisto = decimal.Parse(txPrezzoAcquisto.Text.Replace(".", ","));

                Documento.Dettaglio.Add(riga);

                gridControl1.RefreshDataSource();

            }

            lkArticoli.EditValue = null;
            txQta.Text = "0";
            txLotto.Text = string.Empty;
            txPrezzoAcquisto.Text = "0";

        }
        private void btnCancellaArticolo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancello la riga ordine?",
                   "Gariglio",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Error) == DialogResult.Yes)
            {

                Documento.Dettaglio.Remove(RigaSelezionata);
                Presenter.CancellaRigaDocumento(RigaSelezionata);
                gridControl1.RefreshDataSource();
                RigaSelezionata = null;

            }
        }

        private List<string> VerificaTestata()
        {

            List<string> ErrorMessages = new List<string>();

            if (Cliente == null)
            {
                errorProvider1.SetError(lkCliente, "Dato obbligatorio!!");
                ErrorMessages.Add("Cliente obbligatorio");
            }
            else
            {
                errorProvider1.SetError(lkCliente, "");
            }



            if (DataDocumento == DateTime.MinValue)
            {
                errorProvider1.SetError(dataDocumento, "Dato obbligatorio!!");
                ErrorMessages.Add("Data documento obbligatorio");
            }
            else
            {
                errorProvider1.SetError(dataDocumento, "");
            }

            if (string.IsNullOrEmpty(NumeroDocumento))
            {
                errorProvider1.SetError(txNumeroDocumento, "Dato obbligatorio!!");
                ErrorMessages.Add("N° documento obbligatorio");
            }
            else
            {
                errorProvider1.SetError(txNumeroDocumento, "");
            }

            return ErrorMessages;

        }

        private void VerificaRigaArticolo()
        {

            bool error = false;

            if (ArticoloSelezionato == null)
            {
                error = true;
            }
            if (decimal.Parse(txQta.Text.Replace(".", ",")) == 0)
            {
                error = true;
            }

            if (string.IsNullOrEmpty(txLotto.Text))
            {
                error = true;
            }

            btnAggiungiArticolo.Enabled = !error;

        }

        private void lkCliente_EditValueChanged(object sender, EventArgs e)
        {
            Cliente = (Anagrafica)lkCliente.GetSelectedDataRow();
        }
        private void lkArticoli_EditValueChanged(object sender, EventArgs e)
        {

            ArticoloSelezionato = (Articolo)lkArticoli.GetSelectedDataRow();

            if (ArticoloSelezionato != null)
            {
                lblUM.Text = ArticoloSelezionato.Um;
            }
            else
            {
                lblUM.Text = string.Empty;
            }

        }

        private void txQta_TextChanged(object sender, EventArgs e)
        {

            VerificaRigaArticolo();

        }

        private void dataDocumento_EditValueChanged(object sender, EventArgs e)
        {
            DataDocumento = dataDocumento.DateTime;
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            GridControl grid = sender as GridControl;
            GridView view = grid.Views[0] as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            view.SelectRow(hitInfo.RowHandle);

            if ((e.Button & MouseButtons.Left) != 0 &
                hitInfo.InRow &
                !view.IsGroupRow(hitInfo.RowHandle))
            {
                if (view.GetSelectedRows().Length == 1)
                {

                    lkArticoli.EditValue = null;
                    txQta.Text = "0";

                    RigaSelezionata =
                        (DocumentoRiga)view.GetRow(hitInfo.RowHandle);

                }
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {



        }

        private void lkArticoliIngresso_EditValueChanged(object sender, EventArgs e)
        {
            //RigaSelezionataVasca = (DocumentoRiga)lkArticoliIngresso.GetSelectedDataRow();



        }

        private void txLotto_TextChanged(object sender, EventArgs e)
        {
            VerificaRigaArticolo();
        }

        #endregion

    }
}
