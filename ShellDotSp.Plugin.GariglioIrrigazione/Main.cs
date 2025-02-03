using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using ShellDotSp.Contract.Plugin;
using ShellDotSp.Plugin.GariglioIrrigazione.UI;

namespace ShellDotSp.Plugin.GariglioIrrigazione
{
    [Export(typeof(IPlugin))]
    [ExportMetadata("Codice", "GARIGLIOIRR")]
    [ExportMetadata("Versione", "1.0.0")]
    [ExportMetadata("Descrizione", "Irrigazione")]
    public class Main : IPlugin
    {

        #region Fields
        private static readonly Lazy<MainControlTsPalletMatPrimeCarico> _instance =
            new Lazy<MainControlTsPalletMatPrimeCarico>(() => new MainControlTsPalletMatPrimeCarico());
        private static readonly Lazy<FooterControlTsPalletMatPrimeCarico> _instanceFooter =
           new Lazy<FooterControlTsPalletMatPrimeCarico>(() => new FooterControlTsPalletMatPrimeCarico());
        #endregion

        #region Ctor
        public Main()
        {
        }
        #endregion

        #region Implements IPlugin

        public string Caption
        {
            get
            {
                return "FERTIRRIGAZIONE";
            }
        }
        public string Title
        {
            get
            {
                return "FERTIRRIGAZIONE";
            }
        }
        public Bitmap Image
        {
            get
            {
                return global::ShellDotSp.Plugin.GariglioIrrigazione._48x48.package_import48x48;
            }
        }

        public bool Authorize => throw new NotImplementedException();

        public bool ShowFooter => false;

        public void Finalizza()
        {

        }

        public UserControl GetControl()
        {
            var ret = _instance.Value;
            ret.Inizializza();
            return ret;
        }
        public UserControl GetFooterControl()
        {
            var ret = _instanceFooter.Value;
            ret.Inizializza();
            return ret;
        }

        public void Inizializza()
        {

        }

        #endregion

    }
}
