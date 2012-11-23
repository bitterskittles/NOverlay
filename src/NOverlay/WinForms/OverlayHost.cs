// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OverlayHost.cs" company="bitterskittles">
//   Copyright © bitterskittles 2012
// </copyright>
// <summary>
//   Defines the OverlayHost type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NOverlay.WinForms
{
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Windows.Forms;

    public class OverlayHost : Component
    {
        #region Fields

        private IContainer components;

        #endregion

        #region Constructors and Destructors

        public OverlayHost()
        {
            this.InitializeComponent();
        }

        public OverlayHost(IContainer container)
        {
            container.Add(this);

            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        public ContainerControl ContainerControl { get; set; }

        public override ISite Site
        {
            get
            {
                return base.Site;
            }

            set
            {
                base.Site = value;
                if (value == null)
                {
                    return;
                }

                var host = value.GetService(typeof(IDesignerHost)) as IDesignerHost;
                if (host != null)
                {
                    var componentHost = host.RootComponent;
                    if (componentHost is ContainerControl)
                    {
                        this.ContainerControl = componentHost as ContainerControl;
                    }
                }
            }
        }

        #endregion

        #region Methods

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
        }

        #endregion
    }
}