﻿using System;
using System.Windows.Forms;
using ShellDotSp.Plugin.GariglioGiacenze.Interfaces;
using ShellDotSp.Plugin.GariglioGiacenze.Presenters;

namespace ShellDotSp.Plugin.GariglioGiacenze.UI
    {
    public partial class FooterControlGariglioGiacenze : UserControl, IFooterView
        {

        #region Fields
        private FooterPresenter Presenter;
        #endregion

        #region Ctor
        public FooterControlGariglioGiacenze()
            {
            InitializeComponent();
            Presenter = new FooterPresenter(this);
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
        #endregion

        }
    }
