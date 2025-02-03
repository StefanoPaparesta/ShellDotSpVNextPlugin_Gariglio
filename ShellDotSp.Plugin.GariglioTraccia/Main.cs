using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using ShellDotSp.Contract.Plugin;
using ShellDotSp.Plugin.GariglioTraccia.UI;

namespace ShellDotSp.Plugin.GariglioTraccia
    {
    [Export(typeof(IPlugin))]
    [ExportMetadata("Codice", "GARIGLIOTRC")]
    [ExportMetadata("Versione", "1.0.0")]
    [ExportMetadata("Descrizione", "Gestione Tracciabilità")]
    public class Main : IPlugin
        {

        #region Fields
        private static readonly Lazy<MainControlGariglioTraccia> _instance =
            new Lazy<MainControlGariglioTraccia>(() => new MainControlGariglioTraccia());
        private static readonly Lazy<FooterControlGariglioTraccia> _instanceFooter =
           new Lazy<FooterControlGariglioTraccia>(() => new FooterControlGariglioTraccia());
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
                return "TRACCIA";
                }
            }
        public string Title
            {
            get
                {
                return "TRACCIA";
                }
            }
        public Bitmap Image
            {
            get
                {
                return global::ShellDotSp.Plugin.GariglioTraccia._48x48.traccia_48x48;
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
