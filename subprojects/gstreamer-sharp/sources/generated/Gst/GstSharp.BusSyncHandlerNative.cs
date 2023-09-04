// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate int BusSyncHandlerNative(IntPtr bus, IntPtr message, IntPtr user_data);

	internal class BusSyncHandlerInvoker {

		BusSyncHandlerNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~BusSyncHandlerInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal BusSyncHandlerInvoker (BusSyncHandlerNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal BusSyncHandlerInvoker (BusSyncHandlerNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal BusSyncHandlerInvoker (BusSyncHandlerNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.BusSyncHandler Handler {
			get {
				return new Gst.BusSyncHandler(InvokeNative);
			}
		}

		Gst.BusSyncReply InvokeNative (Gst.Bus bus, Gst.Message message)
		{
			Gst.BusSyncReply __result = (Gst.BusSyncReply) native_cb (bus == null ? IntPtr.Zero : bus.Handle, message == null ? IntPtr.Zero : message.Handle, __data);
			return __result;
		}
	}

	internal class BusSyncHandlerWrapper {

		public int NativeCallback (IntPtr bus, IntPtr message, IntPtr user_data)
		{
			try {
				Gst.BusSyncReply __ret = managed (GLib.Object.GetObject(bus) as Gst.Bus, message == IntPtr.Zero ? null : (Gst.Message) GLib.Opaque.GetOpaque (message, typeof (Gst.Message), false));
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

		internal BusSyncHandlerNative NativeDelegate;
		Gst.BusSyncHandler managed;

		public BusSyncHandlerWrapper (Gst.BusSyncHandler managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new BusSyncHandlerNative (NativeCallback);
		}

		public static Gst.BusSyncHandler GetManagedDelegate (BusSyncHandlerNative native)
		{
			if (native == null)
				return null;
			BusSyncHandlerWrapper wrapper = (BusSyncHandlerWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
