// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.Video.ColorBalanceTypeGType))]
	public enum ColorBalanceType {

		Hardware = 0,
		Software = 1,
	}

	internal class ColorBalanceTypeGType {
		[DllImport ("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_color_balance_type_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_color_balance_type_get_type ());
			}
		}
	}
#endregion
}
