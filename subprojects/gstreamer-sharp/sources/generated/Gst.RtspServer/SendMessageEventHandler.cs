// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServer {

	using System;

	public delegate void SendMessageEventHandler(object o, SendMessageEventArgs args);

	public class SendMessageEventArgs : GLib.SignalArgs {
		public Gst.RtspServer.RTSPSession Session{
			get {
				return (Gst.RtspServer.RTSPSession) Args [0];
			}
		}

		public IntPtr Message{
			get {
				return (IntPtr) Args [1];
			}
		}

	}
}
