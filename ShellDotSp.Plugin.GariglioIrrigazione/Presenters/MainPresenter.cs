using System;
using System.Collections.Generic;
using System.Linq;
using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Model;
using ShellDotSp.Plugin.GariglioIrrigazione.Interfaces;

namespace ShellDotSp.Plugin.GariglioIrrigazione.Presenters
{
    public class MainPresenter : Presenter<IMainView>
    {

        #region Fields

        #endregion

        #region Properties
        public ProgIrrigazione ProgrammaSelezionato { get; set; }
        public List<ProgIrrigazione> ElencoProgrammi { get; set; }
        #endregion

        #region Ctor
        public MainPresenter(IMainView View)
            : base(View)
        {

        }
        #endregion

        #region IMainView
        protected override void CloseView(object sender, EventArgs e)
        {
        }
        protected override void ViewInitialized(object sender, EventArgs e)
        {

            ElencoProgrammi = Repository.Query<ProgIrrigazione>
                ("FROM ProgIrrigazioni ORDER BY CodiceProgramma")
                .ToList();

            View.UpdateUI(Function.ElencoFertirrigazione);

        }
        #endregion

        #region Method
        internal void SetProgrammaSelezionato(ProgIrrigazione Programma)
        {
            ProgrammaSelezionato = Programma;
            View.UpdateUI(Function.ProgFertiSelezionato);
        }

        internal void ManageProgrammaFerti(ProgIrrigazione ProgrammaSelezionato)
        {

            if (ProgrammaSelezionato != null &&
                ProgrammaSelezionato.Id == 0)
            {

                Repository.Insert(ProgrammaSelezionato);

            }

            if (ProgrammaSelezionato != null &&
                ProgrammaSelezionato.Id != 0)
            {

                Repository.Update(ProgrammaSelezionato);

            }

        }

        internal void CancellaProgramma()
        {
            string sql = "DELETE FROM ProgIrrigazioni WHERE Id = @0";
            Repository.Execute(sql, ProgrammaSelezionato.Id);
        }
        #endregion

    }
}
