using System;
using ShellDotSp.Core.Base;
using ShellDotSp.Plugin.GariglioRicetteConcimazione.Interfaces;

namespace ShellDotSp.Plugin.GariglioRicetteConcimazione.Presenters
    {
    public class FooterPresenter : Presenter<IFooterView>
        {

        #region Ctor
        public FooterPresenter(IFooterView View)
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

            }

        #endregion

        }
    }
