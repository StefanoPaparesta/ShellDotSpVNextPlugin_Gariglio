#region Using
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioIngressoMerci.Forms;
using ShellDotSp.Plugin.GariglioIngressoMerci.Interfaces;
using ShellDotSp.Plugin.GariglioIngressoMerci.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioIngressoMerci.UI
{
    public partial class MainControlGarIngresso : UserControl, IMainView
    {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Ctor
        public MainControlGarIngresso()
        {
            InitializeComponent();
            Presenter = new MainPresenter(this);
        }
        #endregion

        #region Implements IMainView

        public string Caption { get; set; }

        private event EventHandler viewInitialized;
        private event EventHandler closeView;

        public event EventHandler CloseView
        {
            add { closeView += value; }
            remove { closeView -= value; }
        }
        public event EventHandler ViewInitialized
        {
            add { viewInitialized += value; }
            remove { viewInitialized -= value; }
        }

        private void InvokeViewInitialized(EventArgs e)
        {
            viewInitialized?.Invoke(this, e);
        }
        private void InvokeCloseView(EventArgs e)
        {
            closeView?.Invoke(this, e);
        }

        public void Finalizza()
        {
            InvokeCloseView(EventArgs.Empty);
        }

        public void Inizializza()
        {

            Presenter.DocumentoSelezionato = null;

            dateEditDal.DateTime = DateTime.Now.AddMonths(-6);
            dateEditAl.DateTime = DateTime.Now;

            Presenter.OrdiniDal = dateEditDal.DateTime;
            Presenter.OrdiniAl = dateEditAl.DateTime;

            InvokeViewInitialized(EventArgs.Empty);
        }

        public void UpdateUI(Function functionName)
        {

            switch (functionName)
            {
                case Function.ElencoDocumenti:
                    bndDocumenti.DataSource = Presenter.Documenti;
                    break;
                case Function.DocumentoSelezionato:

                    btnAggiungi.Enabled = true;
                    btnModifica.Enabled = Presenter.DocumentoSelezionato != null;
                    btnCancella.Enabled = Presenter.DocumentoSelezionato != null;
                    btnPrintLabel.Enabled = Presenter.DocumentoSelezionato != null;

                    break;
            }

        }

        #endregion

        #region UI

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            Presenter.OrdiniDal = dateEditDal.DateTime;
            Presenter.OrdiniAl = dateEditAl.DateTime;
            Presenter.LoadDocumenti();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {

            Presenter.DocumentoSelezionato = null;

            using (FrmIngressoMerci Frm = new FrmIngressoMerci(Presenter))
            {
                if (Frm.ShowDialog() == DialogResult.OK)
                {

                    Presenter.ManageDocumento(Frm.Documento);
                    Presenter.DocumentoSelezionato = null;

                }
            }
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


                    Presenter.DocumentoSelezionato =
                        (VDocumentoTestata)view.GetRow(hitInfo.RowHandle);

                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            using (FrmIngressoMerci Frm = new FrmIngressoMerci(Presenter))
            {
                if (Frm.ShowDialog() == DialogResult.OK)
                {

                    Presenter.ManageDocumento(Frm.Documento);

                }
            }

            Presenter.LoadDocumenti();
            Presenter.DocumentoSelezionato = null;

        }

        private void btnCancella_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Cancello la BEM selezionata ?",
                "Gariglio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Presenter.CancellaDocumento();
                Presenter.LoadDocumenti();
                Presenter.DocumentoSelezionato = null;

            }

        }

        private void btnPrintLabel_Click(object sender, EventArgs e)
        {

            var errors = Presenter.StampaLabelProduzione();

            if (errors.Count != 0)
            {

                MessageBox.Show(string.Join("\r\n", errors),
                "Gariglio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }

        }

        #endregion

    }
}
