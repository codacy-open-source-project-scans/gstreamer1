// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServer {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.RtspServer.RTSPPublishClockModeGType))]
	public enum RTSPPublishClockMode {

		None = 0,
		Clock = 1,
		ClockAndOffset = 2,
	}

	internal class RTSPPublishClockModeGType {
		[DllImport ("gstrtspserver-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_rtsp_publish_clock_mode_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_rtsp_publish_clock_mode_get_type ());
			}
		}
	}
#endregion
}
