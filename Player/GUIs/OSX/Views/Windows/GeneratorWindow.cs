using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace Stoffi.GUI.Views
{
	public partial class GeneratorWindow : MonoMac.AppKit.NSWindow
	{
		#region Constructors
		// Called when created from unmanaged code
		public GeneratorWindow (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public GeneratorWindow (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Shared initialization code
		void Initialize ()
		{
		}
		#endregion
	}
}

