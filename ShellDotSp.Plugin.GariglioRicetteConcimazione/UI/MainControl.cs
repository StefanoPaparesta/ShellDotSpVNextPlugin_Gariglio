#region Using
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.Forms;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.Interfaces;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.Presenters;

#endregion
namespace ShellDotSp.Plugin.GariglioRicetteConcimazione.UI
    {
    public partial class MainControlRicetteConcimazione : UserControl, IMainView
        {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Ctor
        public MainControlRicetteConcimazione()
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
            InvokeViewInitialized(EventArgs.Empty);
            Presenter.SetRicettaSelezionata(null);
            }

        public void UpdateUI(Function functionName)
            {

            switch (functionName)
                {

                case Function.ElencoRicette:

                    bndData.DataSource = Presenter.ElencoRicette;

                    break;
                case Function.RicettaSelezionata:

                    btnAggiungi.Enabled = true;
                    btnModifica.Enabled = Presenter.RicettaSelezionata != null;
                    btnCancella.Enabled = Presenter.RicettaSelezionata != null;
                    btnDettaglio.Enabled = Presenter.RicettaSelezionata != null;

                    break;

                }

            }


        #endregion

        #region UI

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

                    Presenter.SetRicettaSelezionata
                        ((RicettaIrrigazioneTestata)view.GetRow(hitInfo.RowHandle));

                    }
                }

            }

        private void btnFiltra_Click(object sender, EventArgs e)
            {
            InvokeViewInitialized(EventArgs.Empty);
            Presenter.SetRicettaSelezionata(null);
            }

        private void btnDettaglio_Click(object sender, EventArgs e)
            {

            using (FrmDettaglioRicetta frm =
                new FrmDettaglioRicetta(Presenter))
                {

                if (frm.ShowDialog() == DialogResult.OK)
                    {
                    Presenter.SetRicettaSelezionata(null);
                    }

                }

            }

        private void btnAggiungi_Click(object sender, EventArgs e)
            {

            using (FrmTestataRicetta frm = new FrmTestataRicetta(Presenter))
                {
                frm.Ricetta = null;

                if (frm.ShowDialog() == DialogResult.OK)
                    {
                    Presenter.ManageRicetta(frm.Ricetta);
                    InvokeViewInitialized(EventArgs.Empty);
                    Presenter.SetRicettaSelezionata(null);
                    }
                }

            }

        private void btnModifica_Click(object sender, EventArgs e)
            {

            using (FrmTestataRicetta frm = new FrmTestataRicetta(Presenter))
                {
                frm.Ricetta = Presenter.RicettaSelezionata;

                if (frm.ShowDialog() == DialogResult.OK)
                    {
                    Presenter.ManageRicetta(frm.Ricetta);
                    InvokeViewInitialized(EventArgs.Empty);
                    Presenter.SetRicettaSelezionata(null);
                    }
                }

            }

        private void btnCancella_Click(object sender, EventArgs e)
            {

            if (MessageBox.Show("Confermi la cancellazione della riga selezionata ?",
               "Gariglio",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                Presenter.CancellaRicetta();
                InvokeViewInitialized(EventArgs.Empty);
                Presenter.SetRicettaSelezionata(null);
                }

            }
        #endregion






        }
    }
