// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.RtspServerSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate int RTSPServerClientFilterFuncNative(IntPtr server, IntPtr client, IntPtr user_data);

	internal class RTSPServerClientFilterFuncInvoker {

		RTSPServerClientFilterFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~RTSPServerClientFilterFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal RTSPServerClientFilterFuncInvoker (RTSPServerClientFilterFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal RTSPServerClientFilterFuncInvoker (RTSPServerClientFilterFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal RTSPServerClientFilterFuncInvoker (RTSPServerClientFilterFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.RtspServer.RTSPServerClientFilterFunc Handler {
			get {
				return new Gst.RtspServer.RTSPServerClientFilterFunc(InvokeNative);
			}
		}

		Gst.RtspServer.RTSPFilterResult InvokeNative (Gst.RtspServer.RTSPServer server, Gst.RtspServer.RTSPClient client)
		{
			Gst.RtspServer.RTSPFilterResult __result = (Gst.RtspServer.RTSPFilterResult) native_cb (server == null ? IntPtr.Zero : server.Handle, client == null ? IntPtr.Zero : client.Handle, __data);
			return __result;
		}
	}

	internal class RTSPServerClientFilterFuncWrapper {

		public int NativeCallback (IntPtr server, IntPtr client, IntPtr user_data)
		{
			try {
				Gst.RtspServer.RTSPFilterResult __ret = managed (GLib.Object.GetObject(server) as Gst.RtspServer.RTSPServer, GLib.Object.GetObject(client) as Gst.RtspServer.RTSPClient);
				if (release_on_call)
					gch.Free ();
				return (int) __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal RTSPServerClientFilterFuncNative NativeDelegate;
		Gst.RtspServer.RTSPServerClientFilterFunc managed;

		public RTSPServerClientFilterFuncWrapper (Gst.RtspServer.RTSPServerClientFilterFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new RTSPServerClientFilterFuncNative (NativeCallback);
		}

		public static Gst.RtspServer.RTSPServerClientFilterFunc GetManagedDelegate (RTSPServerClientFilterFuncNative native)
		{
			if (native == null)
				return null;
			RTSPServerClientFilterFuncWrapper wrapper = (RTSPServerClientFilterFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}