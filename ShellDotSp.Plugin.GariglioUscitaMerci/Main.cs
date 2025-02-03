using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using ShellDotSp.Contract.Plugin;
using ShellDotSp.Plugin.GariglioUscitaMerci.UI;

namespace ShellDotSp.Plugin.GariglioUscitaMerci
{
    [Export(typeof(IPlugin))]
    [ExportMetadata("Codice", "GARIGLIOUSC")]
    [ExportMetadata("Versione", "1.0.0")]
    [ExportMetadata("Descrizione", "Uscita prodotti")]
    public class Main : IPlugin
    {

        #region Fields
        private static readonly Lazy<MainControlGariglioUscita> _instance =
            new Lazy<MainControlGariglioUscita>(() => new MainControlGariglioUscita());
        private static readonly Lazy<FooterControlGariglioUscita> _instanceFooter =
           new Lazy<FooterControlGariglioUscita>(() => new FooterControlGariglioUscita());
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
                return "VENDITA";
            }
        }
        public string Title
        {
            get
            {
                return "VENDITA";
            }
        }
        public Bitmap Image
        {
            get
            {
                return global::ShellDotSp.Plugin.GariglioUscitaMerci._48x48.package_import48x48;
            }
        }

        public bool Authorize => throw new NotImplementedException();

        public bool ShowFooter => false;

        public void Finalizza()
        {
        }
        public void Inizializza()
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


        #endregion

    }
}
