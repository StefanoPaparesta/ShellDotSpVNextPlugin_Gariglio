#region Using
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using DotSpExtensions.Winforms;

using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioTraccia.Forms;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.View
{
    public partial class CicliProduzioneView : UserControl, ILocalView
    {

        #region Fields
        private MainPresenter Presenter;
        private MsgBoxHelper Msg = new MsgBoxHelper(Properties.Resources.MsgTitolo);
        #endregion

        #region Properties

        #endregion

        #region Ctor

        public CicliProduzioneView(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }

        #endregion

        #region Implements ILocalView

        public void OnFinalize()
        {

        }

        public void OnInit()
        {

            dateEditDal.DateTime = DateTime.Today.AddDays(-30);
            dateEditAl.DateTime = DateTime.Today;

            Presenter.LoadCicliFilter();

            bndMP.Clear();
            bndUbicazioni.Clear();
            Presenter.SetMovimentoDettaglioSelezionato(null);
            Presenter.SetTracciaMPSelezionata(null);

        }

        public void UpdateUI(string functionName)
        {

            switch (functionName)
            {
                case "listaCicliProduzione":

                    if (Presenter.CicliProduzione.Count == 0)
                    {
                        bndTracciaTestata.Clear();
                    }
                    else
                    {
                        bndTracciaTestata.DataSource = Presenter.CicliProduzione;
                    }

                    break;
                case "listaCicliProduzioneDett":

                    if (Presenter.CicliProduzioneUbi.Count == 0)
                    {
                        bndUbicazioni.Clear();
                    }
                    else
                    {
                        bndUbicazioni.DataSource = Presenter.CicliProduzioneUbi;
                    }

                    if (Presenter.CicliProduzioneMP.Count == 0)
                    {
                        bndMP.Clear();
                    }
                    else
                    {
                        bndMP.DataSource = Presenter.CicliProduzioneMP;
                    }

                    break;
                case "listaCicliLavorazioni":

                    if (Presenter.CicliLavorazioni.Count == 0)
                    {
                        bndCicli.Clear();
                    }
                    else
                    {
                        bndCicli.DataSource = Presenter.CicliLavorazioni;
                        lkCicli.EditValue = "ALL";
                    }

                    Presenter.LoadCicliProduzione(dateEditDal.DateTime,
                                                    dateEditAl.DateTime,
                                                    lkCicli.EditValue.ToString());

                    break;
                case "movimentoDettaglioSelezionato":
                    VerificaDropDownMenu();
                    break;
                case "tracciaMPSelezionata":
                    VerificaDropDownMenu();
                    break;
            }

        }

        #endregion

        #region UI

        private void btnFiltra_Click(object sender, System.EventArgs e)
        {
            Presenter.LoadCicliProduzione(dateEditDal.DateTime,
                                 dateEditAl.DateTime,
                                 lkCicli.EditValue.ToString());

            bndMP.Clear();
            bndUbicazioni.Clear();

        }

        private void GridControl1_MouseClick(object sender, MouseEventArgs e)
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

                    VTracciaTestata Testata
                        = (VTracciaTestata)view.GetRow(view.GetSelectedRows()[0]);
                    Presenter.SetTestataTraccia(Testata);

                    Presenter.SetMovimentoDettaglioSelezionato(null);
                    Presenter.SetTracciaMPSelezionata(null);

                }
            }
        }

        private void BtnModifica_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnCancella_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Cancello la riga selezionata ?",
               "Magazzino",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information) == DialogResult.Yes
               )
            {


            }
        }

        private void btnActions_Click(object sender, EventArgs e)
        {
            VerificaDropDownMenu();
            btnActions.ShowDropDown();
        }

        private void VerificaDropDownMenu()
        {
            btnCancellaMovimento.Enabled = Presenter.MovimentoDettaglioSelezionato != null;
            btnModificaMovimento.Enabled = Presenter.MovimentoDettaglioSelezionato != null;

            btnCancellaMP.Enabled = Presenter.TracciaMPSelezionata != null;
            btnModificaMP.Enabled = Presenter.TracciaMPSelezionata != null;

            btnCancellaTestata.Enabled = Presenter.CicloProduzioneSel != null;

        }

        //Movimenti
        private void gridControl2_MouseClick(object sender, MouseEventArgs e)
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

                    var movimento = (MagazzinoMovimento)view.GetRow(view.GetSelectedRows()[0]);
                    Presenter.SetMovimentoDettaglioSelezionato(movimento);
                    Presenter.SetTracciaMPSelezionata(null);

                }
            }
        }

        //Materie prime
        private void gridControl3_MouseClick(object sender, MouseEventArgs e)
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

                    var MP = (VTracciaMateriePrime)view.GetRow(view.GetSelectedRows()[0]);
                    Presenter.SetTracciaMPSelezionata(MP);
                    Presenter.SetMovimentoDettaglioSelezionato(null);
                }
            }
        }

        private void tabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {

            if (e.Page.Equals(tabNavigationPage1))
            {
                bndMP.Clear();
                bndUbicazioni.Clear();
                Presenter.SetMovimentoDettaglioSelezionato(null);
                Presenter.SetTracciaMPSelezionata(null);
                Presenter.LoadCicliProduzione(dateEditDal.DateTime,
                                                dateEditAl.DateTime,
                                                lkCicli.EditValue.ToString());
            }

            if (e.Page.Equals(tabNavigationPage2))
            {

            }

        }

        #endregion

        #region Action Menu

        private void btnModificaMovimento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmModificaMovimento Frm = new FrmModificaMovimento(Presenter))
            {

                if (Frm.ShowDialog() == DialogResult.OK)
                {
                    Presenter.ManageMovimentoDettaglio();
                }

                Presenter.SetMovimentoDettaglioSelezionato(null);
                Presenter.SetTracciaMPSelezionata(null);

            }
        }

        private void btnCancellaMovimento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Msg.Question("Cancello definitivamente il movimento selezionato ?") == DialogResult.Yes)
            {
                Presenter.CancellaMovimentoDettaglio();
            }

            Presenter.SetMovimentoDettaglioSelezionato(null);
            Presenter.SetTracciaMPSelezionata(null);

        }

        private void btnModificaMP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (FrmModificaMP Frm = new FrmModificaMP(Presenter))
            {

                if (Frm.ShowDialog() == DialogResult.OK)
                {
                    Presenter.ManageTracciaMP();
                }

                Presenter.SetMovimentoDettaglioSelezionato(null);
                Presenter.SetTracciaMPSelezionata(null);

            }
        }

        private void btnCancellaMP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Msg.Question("Cancello definitivamente la materia prima ?") == DialogResult.Yes)
            {
                Presenter.CancellaTracciaMP();
            }

            Presenter.SetMovimentoDettaglioSelezionato(null);
            Presenter.SetTracciaMPSelezionata(null);

        }

        private void btnCancellaTestata_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            StringBuilder bld = new StringBuilder();
            bld.AppendLine("ATTENZIONE, stai per cancellare il ciclo :");
            bld.AppendLine($"#{Presenter.CicloProduzioneSel.Id} {Presenter.CicloProduzioneSel.CicloDescrizione} del {Presenter.CicloProduzioneSel.DataDocumento:dd/MM/yyyy}");
            bld.AppendLine("ti ricordo che con questa operazione cancelli");
            bld.AppendLine("la TESTATA e TUTTI i dettagli");
            bld.AppendLine("questa operazione non è reversibile !!!!!");
            bld.AppendLine("Procedo ?");

            if (Msg.Question(bld.ToString()) == DialogResult.Yes)
            {
                Presenter.CancellaTestata();

                Presenter.SetMovimentoDettaglioSelezionato(null);
                Presenter.SetTracciaMPSelezionata(null);
                Presenter.SetTestataTraccia(null);

                Presenter.LoadCicliProduzione(dateEditDal.DateTime,
                                dateEditAl.DateTime,
                                lkCicli.EditValue.ToString());

                bndMP.Clear();
                bndUbicazioni.Clear();

            }

        }

        #endregion


    }
}
