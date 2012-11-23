// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OverlaySource.cs" company="bitterskittles">
//   Copyright © bitterskittles 2012
// </copyright>
// <summary>
//   Defines the OverlaySource type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NOverlay
{
    using System;

    public class OverlaySource
    {
        #region Fields

        private readonly IntPtr hwnd;

        #endregion

        #region Constructors and Destructors

        public OverlaySource(IntPtr hwnd)
        {
            this.hwnd = hwnd;
        }

        #endregion
    }
}