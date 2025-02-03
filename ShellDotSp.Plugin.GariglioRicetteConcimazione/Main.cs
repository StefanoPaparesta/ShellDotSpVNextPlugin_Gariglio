using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using ShellDotSp.Contract.Plugin;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.UI;

namespace ShellDotSp.Plugin.GariglioRicetteConcimazione
{
    [Export(typeof(IPlugin))]
    [ExportMetadata("Codice", "GARIGLIORIC")]
    [ExportMetadata("Versione", "1.0.0")]
    [ExportMetadata("Descrizione", "Materie Prime Carico")]
    public class Main : IPlugin
    {

        #region Fields
        private static readonly Lazy<MainControlRicetteConcimazione> _instance =
            new Lazy<MainControlRicetteConcimazione>(() => new MainControlRicetteConcimazione());
        private static readonly Lazy<FooterControlGariglioRicetteConcimazione> _instanceFooter =
           new Lazy<FooterControlGariglioRicetteConcimazione>(() => new FooterControlGariglioRicetteConcimazione());
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
                return "MEZZI\r\nTECNICI";
            }
        }
        public string Title
        {
            get
            {
                return "MEZZI TECNICI";
            }
        }
        public Bitmap Image
        {
            get
            {
                return global::ShellDotSp.Plugin.GariglioRicetteConcimazione._48x48.package_import48x48;
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
