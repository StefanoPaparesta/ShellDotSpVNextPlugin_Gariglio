using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using ShellDotSp.Contract.Plugin;
using ShellDotSp.Plugin.GariglioGiacenze.UI;

namespace ShellDotSp.Plugin.GariglioGiacenze
    {
    [Export(typeof(IPlugin))]
    [ExportMetadata("Codice", "GARIGLIOGIAC")]
    [ExportMetadata("Versione", "1.0.0")]
    [ExportMetadata("Descrizione", "Giacenze")]
    public class Main : IPlugin
        {

        #region Fields
        private static readonly Lazy<MainControlGariglioGiacenze> _instance =
            new Lazy<MainControlGariglioGiacenze>(() => new MainControlGariglioGiacenze());
        private static readonly Lazy<FooterControlGariglioGiacenze> _instanceFooter =
           new Lazy<FooterControlGariglioGiacenze>(() => new FooterControlGariglioGiacenze());
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
                return "GIACENZE";
                }
            }
        public string Title
            {
            get
                {
                return "GESTIONE GIACENZE";
                }
            }
        public Bitmap Image
            {
            get
                {
                return global::ShellDotSp.Plugin.GariglioGiacenze._48x48.package_import48x48;
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
