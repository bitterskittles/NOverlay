// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OverlayService.cs" company="bitterskittles">
//   Copyright © bitterskittles 2012
// </copyright>
// <summary>
//   Defines the OverlayService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NOverlay
{
    using System.ComponentModel.Composition;

    [Export(typeof(IOverlayService))]
    public class OverlayService : IOverlayService
    {
    }
}