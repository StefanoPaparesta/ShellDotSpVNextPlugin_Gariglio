using System;
using System.Windows.Forms;
using ShellDotSp.Plugin.GariglioAnag.Interfaces;
using ShellDotSp.Plugin.GariglioAnag.Presenters;
using ShellDotSp.Plugin.GariglioCore.Core.Util;
using ShellDotSp.Plugin.GariglioCore.Interfaces;

namespace ShellDotSp.Plugin.GariglioAnag.UI
    {
    public partial class MainControlGariglioAnag : UserControl, IMainView
        {

        #region Fields

        private MainPresenter Presenter;

        #endregion

        #region Ctor
        public MainControlGariglioAnag()
            {
            InitializeComponent();
            Presenter = new MainPresenter(this);
            }
        #endregion

        #region Implements IMainView

        public string Caption { get; set; }

        private event EventHandler viewInitialized;
        private event EventHandler closeView;

        public event EventHandler CloseView
            {
            add { closeView += value; }
            remove { closeView -= value; }
            }
        public event EventHandler ViewInitialized
            {
            add { viewInitialized += value; }
            remove { viewInitialized -= value; }
            }

        private void InvokeViewInitialized(EventArgs e)
            {
            viewInitialized?.Invoke(this, e);
            }
        private void InvokeCloseView(EventArgs e)
            {
            closeView?.Invoke(this, e);
            }

        public void Finalizza()
            {
            InvokeCloseView(EventArgs.Empty);
            }

        public void Inizializza()
            {
            InvokeViewInitialized(EventArgs.Empty);
            }

        public void UpdateCurrentePage(string functionName)
            {
            var view = ((ILocalView)panelDesktop.Controls[Presenter.PaginaCorrente]);
            view.UpdateUI(functionName);
            }

        #endregion

        #region UI

        private void Toolbar_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
            {
            CaricaView(e.Item.Tag.ToString());
            }

        #endregion

        #region Method

        private void CaricaView(string Name)
            {

            string typeName = $"ShellDotSp.Plugin.GariglioAnag.View.{Name}";

            if (!Presenter.Pagine.ContainsKey(Name))
                {

                if (!string.IsNullOrEmpty(Presenter.PaginaCorrente) &&
                    Presenter.PaginaCorrente != Name)
                    {
                    ((ILocalView)panelDesktop.Controls[Presenter.PaginaCorrente]).OnFinalize();
                    }

                var ctrl = ObjActivator.GetInstance<UserControl>(typeName, Presenter);
                ctrl.Dock = DockStyle.Fill;
                ctrl.Name = Name;

                Presenter.Pagine.Add(Name, typeName);

                panelDesktop.Controls.Add(ctrl);
                panelDesktop.Controls[Name].BringToFront();

                Presenter.PaginaCorrente = Name;

                }
            else
                {

                if (!string.IsNullOrEmpty(Presenter.PaginaCorrente) &&
                    Presenter.PaginaCorrente != Name)
                    {
                    ((ILocalView)panelDesktop.Controls[Presenter.PaginaCorrente]).OnFinalize();
                    }

                panelDesktop.Controls[Name].BringToFront();

                Presenter.PaginaCorrente = Name;

                }

            ((ILocalView)panelDesktop.Controls[Name]).OnInit();

            }

        #endregion

        }
    }
