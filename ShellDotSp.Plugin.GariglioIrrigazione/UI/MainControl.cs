#region Using
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioIrrigazione.Forms;
using ShellDotSp.Plugin.GariglioIrrigazione.Interfaces;
using ShellDotSp.Plugin.GariglioIrrigazione.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioIrrigazione.UI
{
    public partial class MainControlTsPalletMatPrimeCarico :
        UserControl, IMainView
    {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Ctor
        public MainControlTsPalletMatPrimeCarico()
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
            Presenter.SetProgrammaSelezionato(null);
        }

        public void UpdateUI(Function functionName)
        {
            switch (functionName)
            {
                case Function.ElencoFertirrigazione:
                    bndData.DataSource = Presenter.ElencoProgrammi;
                    break;
                case Function.ProgFertiSelezionato:

                    btnAggiungi.Enabled = true;
                    btnModifica.Enabled = Presenter.ProgrammaSelezionato != null;
                    btnCancella.Enabled = Presenter.ProgrammaSelezionato != null;

                    break;
                default:
                    break;
            }
        }


        #endregion

        #region UI
        private void btnAggiungi_Click(object sender, EventArgs e)
        {

            using (FrmProgrammaFerti frm = new FrmProgrammaFerti(Presenter))
            {
                frm.ProgrammaSelezionato = null;

                if (frm.ShowDialog() == DialogResult.OK)
                {

                    Presenter.ManageProgrammaFerti(frm.ProgrammaSelezionato);
                    InvokeViewInitialized(EventArgs.Empty);

                }
            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            using (FrmProgrammaFerti frm = new FrmProgrammaFerti(Presenter))
            {
                frm.ProgrammaSelezionato = Presenter.ProgrammaSelezionato;

                if (frm.ShowDialog() == DialogResult.OK)
                {

                    Presenter.ManageProgrammaFerti(frm.ProgrammaSelezionato);
                    InvokeViewInitialized(EventArgs.Empty);

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


                    Presenter.SetProgrammaSelezionato
                        ((ProgIrrigazione)view.GetRow(hitInfo.RowHandle));

                }
            }
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Proseguo con la cancellazione del programma utilizzato ?",
                     "Gariglio",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.No)

            {

                return;

            }

            Presenter.CancellaProgramma();
            InvokeViewInitialized(EventArgs.Empty);
            Presenter.SetProgrammaSelezionato(null);

        }

        #endregion


    }
}
