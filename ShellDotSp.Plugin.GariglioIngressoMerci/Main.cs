using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using ShellDotSp.Contract.Plugin;
using ShellDotSp.Plugin.GariglioIngressoMerci.UI;

namespace ShellDotSp.Plugin.GariglioIngressoMerci
    {
    [Export(typeof(IPlugin))]
    [ExportMetadata("Codice", "GARIGLIOMAT")]
    [ExportMetadata("Versione", "1.0.0")]
    [ExportMetadata("Descrizione", "Materie Prime Carico")]
    public class Main : IPlugin
        {

        #region Fields
        private static readonly Lazy<MainControlGarIngresso> _instance =
            new Lazy<MainControlGarIngresso>(() => new MainControlGarIngresso());
        private static readonly Lazy<FooterControlGarIngresso> _instanceFooter =
           new Lazy<FooterControlGarIngresso>(() => new FooterControlGarIngresso());
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
                return "INGRESSO MERCI";
                }
            }
        public string Title
            {
            get
                {
                return "INGRESSO MERCI";
                }
            }
        public Bitmap Image
            {
            get
                {
                return global::ShellDotSp.Plugin.GariglioIngressoMerci._48x48.package_import48x48;
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
