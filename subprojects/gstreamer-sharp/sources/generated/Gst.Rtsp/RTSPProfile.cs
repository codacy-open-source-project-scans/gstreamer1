// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Rtsp.RTSPProfileGType))]
	public enum RTSPProfile : uint {

		Unknown = 0,
		Avp = 1,
		Savp = 2,
		Avpf = 4,
		Savpf = 8,
	}

	internal class RTSPProfileGType {
		[DllImport ("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_profile_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtsp_profile_get_type ());
			}
		}
	}
#endregion
}
