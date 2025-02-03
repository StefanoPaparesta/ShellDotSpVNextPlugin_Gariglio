using System;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Windows.Forms;
using ShellDotSp.Contract.Plugin;
using ShellDotSp.Plugin.GariglioAnag.UI;

namespace ShellDotSp.Plugin.GariglioAnag
    {
    [Export(typeof(IPlugin))]
    [ExportMetadata("Codice", "GARIGLIOANAG")]
    [ExportMetadata("Versione", "1.0.0")]
    [ExportMetadata("Descrizione", "Gestione Anagrafiche")]
    public class Main : IPlugin
        {

        #region Fields
        private static readonly Lazy<MainControlGariglioAnag> _instance =
            new Lazy<MainControlGariglioAnag>(() => new MainControlGariglioAnag());
        private static readonly Lazy<FooterControlGariglioAnag> _instanceFooter =
           new Lazy<FooterControlGariglioAnag>(() => new FooterControlGariglioAnag());
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
                return "ANAGRAFICHE";
                }
            }
        public string Title
            {
            get
                {
                return "ANAGRAFICHE";
                }
            }
        public Bitmap Image
            {
            get
                {
                return global::ShellDotSp.Plugin.GarigliaAnag._48x48.gridlines2_team;
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
