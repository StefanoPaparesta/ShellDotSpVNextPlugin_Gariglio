#region Using
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioRicetteConcimazione.Forms
{
    public partial class FrmDettaglioRicetta : Form
    {

        #region Fields

        private MainPresenter Presenter;
        private VRicettaDettaglio _DettSelezionato;

        #endregion

        #region Properties

        public List<Articolo> Fertilizzanti { get; set; }
        public List<Ubicazione> Taniche { get; set; }
        public List<VRicettaDettaglio> Dettaglio { get; set; }

        public VRicettaDettaglio DettSelezionato
        {
            get { return _DettSelezionato; }
            set
            {
                _DettSelezionato = value;
                btnCancella.Enabled = value != null;
            }
        }

        public Articolo ArticoloSelezionato { get; set; }
        public Ubicazione UbicazioneSelezionata { get; set; }
        public decimal Qta { get; set; } = 0;

        #endregion

        #region Ctor
        public FrmDettaglioRicetta(MainPresenter Presenter)
        {
            InitializeComponent();
            this.Presenter = Presenter;
        }
        #endregion

        #region UI

        private void FrmDettaglioRicetta_Load(object sender, System.EventArgs e)
        {

            Fertilizzanti = Presenter.LoadFertilizzanti();
            Taniche = Presenter.LoadTaniche();

            bndTaniche.DataSource = Taniche;
            bndArticoli.DataSource = Fertilizzanti;

            LoadDettaglioRicette();
            DettSelezionato = null;


        }

        private void LoadDettaglioRicette()
        {
            Dettaglio = Presenter.LoadDettaglioRicettaSelezionata();
            bndData.DataSource = Dettaglio;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancella_Click(object sender, System.EventArgs e)
        {

            if (MessageBox.Show("Confermi la cancellazione della riga selezionata ?",
                "Gariglio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Presenter.CancellaDettaglioRicetta(DettSelezionato);
                LoadDettaglioRicette();
                DettSelezionato = null;
            }

        }

        private void btnAggiungi_Click(object sender, System.EventArgs e)
        {

            var errors = VerificaDati();

            if (errors.Count == 0)
            {

                var item = new RicettaIrrigazioneDettaglio()
                {
                    CodiceTanica = UbicazioneSelezionata.Codice,
                    IdArticolo = ArticoloSelezionato.Id,
                    Qta = Qta,
                    IdTestata = Presenter.RicettaSelezionata.Id
                };

                Presenter.AddDettaglioRicetta(item);
                LoadDettaglioRicette();

                lkArticolo.EditValue = null;
                lkTanica.EditValue = null;

                txQta.Text = 0.ToString();
                Qta = 0;

                DettSelezionato = null;

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

        private List<string> VerificaDati()
        {

            List<string> ret = new List<string>();

            Qta = decimal.Parse(txQta.Text);
            ArticoloSelezionato = (Articolo)lkArticolo.GetSelectedDataRow();
            UbicazioneSelezionata = (Ubicazione)lkTanica.GetSelectedDataRow();


            if (Qta == 0)
            {
                ret.Add("QTA = 0");
                errorProvider1.SetError(txQta, "Deve essere <> da 0");
            }
            else
            {
                errorProvider1.SetError(txQta, "");
            }

            if (ArticoloSelezionato == null)
            {
                ret.Add("Articolo non selezionato");
                errorProvider1.SetError(lkArticolo, "Articolo obbligatorio");
            }
            else
            {
                errorProvider1.SetError(lkArticolo, "");
            }

            if (UbicazioneSelezionata == null)
            {
                ret.Add("Tanica non selezionata");
                errorProvider1.SetError(lkTanica, "Tanica obbligatoria");
            }
            else
            {
                errorProvider1.SetError(lkTanica, "");
            }

            if (ArticoloSelezionato != null)
            {
                var qryCount = (from x
                           in Dettaglio
                                where x.IdArticolo == ArticoloSelezionato.Id
                                select x).Count();

                if (qryCount >= 1)
                {
                    ret.Add("Articolo già utilizzato nella ricetta");
                }

            }

            if (ret.Count != 0)
            {
                ret.Insert(0, "ERRORI RILEVATI :");
            }

            return ret;

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

                    DettSelezionato =
                         ((VRicettaDettaglio)view.GetRow(hitInfo.RowHandle));

                }
            }
        }

        #endregion

    }
}
