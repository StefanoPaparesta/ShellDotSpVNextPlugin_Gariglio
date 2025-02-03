namespace ShellDotSp.Plugin.GariglioCore.Util
{
    using System;
    using System.Linq;
    using ShellDotSp.Contract.Plugin;
    using ShellDotSp.Plugin.GariglioCore.Model;

    namespace GariglioServer.Core.Service
    {
        public class CounterBase
        {

            #region Fields
            private string sqlContatore = "FROM Contatori WHERE Tipo = @0";
            private Contatore ContatorCorrente = null;
            private IRepository Db;
            #endregion

            #region Ctor
            public CounterBase(IRepository Db)
            {
                this.Db = Db;
            }
            #endregion

            #region Function
            protected string GetNextValue(string Tipo)
            {

                ContatorCorrente = Db.Query<Contatore>(sqlContatore, Tipo).SingleOrDefault();

                if (ContatorCorrente.Anno != DateTime.Today.Year)
                {
                    ContatorCorrente.Anno = DateTime.Today.Year;
                    ContatorCorrente.Valore = 0;
                    Db.Update(ContatorCorrente);
                }

                int nextValue = ContatorCorrente.Valore + 1;
                ContatorCorrente.Valore = nextValue;
                Db.Update(ContatorCorrente);

                return FormatCounter(ContatorCorrente.Valore);

            }

            public virtual string FormatCounter(int value)
            {
                return value.ToString();
            }
            #endregion

        }

        public class CounterDocDDT
            : CounterBase
        {

            #region Ctor
            public CounterDocDDT(IRepository Db)
                    : base(Db)
            {

            }
            #endregion

            #region Function
            public override string FormatCounter(int value)
            {
                return $"{value}/{DateTime.Today.Year.ToString().Substring(2, 2)}";
            }

            public string GetNextValue()
            {
                return GetNextValue("004");
            }
            #endregion

        }


    }

}
