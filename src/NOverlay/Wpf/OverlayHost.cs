// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OverlayHost.cs" company="bitterskittles">
//   Copyright © bitterskittles 2012
// </copyright>
// <summary>
//   Defines the OverlayHost type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NOverlay.Wpf
{
    using System.Windows;

    public class OverlayHost
    {
        #region Static Fields

        public static readonly DependencyProperty IsOverlaySourceProperty =
            DependencyProperty.RegisterAttached(
                "IsOverlaySource", 
                typeof(bool), 
                typeof(OverlayHost), 
                new PropertyMetadata(false, IsOverlaySourceChanged));

        #endregion

        #region Public Methods and Operators

        public static bool GetIsOverlaySourceProperty(Window window)
        {
            return (bool)window.GetValue(IsOverlaySourceProperty);
        }

        public static void SetIsOverlaySource(Window window, bool value)
        {
            window.SetValue(IsOverlaySourceProperty, value);
        }

        #endregion

        #region Methods

        private static void IsOverlaySourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        #endregion
    }
}