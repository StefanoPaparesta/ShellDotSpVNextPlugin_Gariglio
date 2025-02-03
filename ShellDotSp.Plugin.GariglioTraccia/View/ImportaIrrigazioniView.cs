#region Using
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ShellDotSp.Plugin.GariglioCore.Interfaces;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioTraccia.Presenters;
#endregion

namespace ShellDotSp.Plugin.GariglioTraccia.View
{
    public partial class ImportaIrrigazioniView : UserControl, ILocalView
    {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Ctor

        public ImportaIrrigazioniView(MainPresenter Presenter)
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

            btnImporta.Enabled = true;
            dateEditDal.DateTime = DateTime.Now.AddMonths(-6);
            dateEditAl.DateTime = DateTime.Now;
            Presenter.LoadIrrigazioni(dateEditDal.DateTime, dateEditAl.DateTime);

        }

        public void UpdateUI(string functionName)
        {
            switch (functionName)
            {
                case "listaIrrigazioni":
                    bndData.DataSource = Presenter.Irrigazioni;
                    break;
            }
        }

        #endregion

        #region UI

        private void btnImporta_Click(object sender, System.EventArgs e)
        {
            List<string> rows = new List<string>();
            string fileName = string.Empty;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {

                dlg.Filter = "dat files (*.dat)|*.dat";
                dlg.RestoreDirectory = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    //Eseguo pulizia del file per l'importazione
                    fileName = dlg.FileName;

                    string[] lines = File.ReadAllLines(fileName);

                    foreach (var item in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(item))
                        {
                            rows.Add(item.Replace(" AGRIMIX N. 1 N.PROG.=", "|"));
                        }
                    }

                }

            }


            if (rows.Count != 0)
            {
                var ErrorMessages = Presenter.ImportIrrigazioni(rows);

                if (ErrorMessages.Count == 0)
                {

                    var dir = Path.GetDirectoryName(fileName);

                    string dirBarckup = Path.Combine(dir, "Backup");

                    if (!Directory.Exists(dirBarckup))
                    {
                        Directory.CreateDirectory(dirBarckup);
                    }

                    string FileNameBackup = Path.Combine(dirBarckup, $"{DateTime.Today.ToString("ddMMyyyy")}_{Path.GetRandomFileName()}.bak");
                    File.Move(fileName, FileNameBackup);

                    Presenter.LoadIrrigazioni(dateEditDal.DateTime, dateEditAl.DateTime);

                    MessageBox.Show("Importazione effettuata con successo",
                        "Gariglio",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    string message = string.Join("\r\n", ErrorMessages);

                    MessageBox.Show(message,
                        "Gariglio",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }

            }

        }

        private void dateEditDal_EditValueChanged(object sender, EventArgs e)
        {

            if (dateEditDal.DateTime != DateTime.MinValue
                && dateEditAl.DateTime != DateTime.MinValue)
            {
                Presenter.LoadIrrigazioni(dateEditDal.DateTime, dateEditAl.DateTime);
            }

        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            if (dateEditDal.DateTime != DateTime.MinValue
               && dateEditAl.DateTime != DateTime.MinValue)
            {
                Presenter.LoadIrrigazioni(dateEditDal.DateTime, dateEditAl.DateTime);
            }
        }

        private void btnCancella_Click(object sender, EventArgs e)
        {

            int[] handledSelected = gridView1.GetSelectedRows();
            List<int> Id = new List<int>();

            if (handledSelected.Length == 0)
            {
                MessageBox.Show("Nessuna riga selezionata",
                       "Gariglio",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            else
            {

                if (MessageBox.Show($"Proseguo con la cancellazione delle {handledSelected.Length} righe selezionate ?",
                       "Gariglio",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.No)

                {

                    return;

                }

                foreach (var idx in handledSelected)
                {
                    var obj = (ProgIrrigazioneDato)gridView1.GetRow(idx);

                    if (obj != null)
                    {
                        Id.Add(obj.Id);
                    }
                }

                if (Id.Count != 0)
                {
                    Presenter.DeleteProgIrrigazioneDati(Id);
                    Presenter.LoadIrrigazioni(dateEditDal.DateTime, dateEditAl.DateTime);
                }

            }

        }
        #endregion


    }
}
