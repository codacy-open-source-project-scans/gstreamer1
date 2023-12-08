// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class RTSPWatch : GLib.Opaque {

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_rtsp_watch_attach(IntPtr raw, IntPtr context);

		public uint Attach(GLib.MainContext context) {
			uint raw_ret = gst_rtsp_watch_attach(Handle, context == null ? IntPtr.Zero : context.Handle);
			uint ret = raw_ret;
			return ret;
		}

		public uint Attach() {
			return Attach (null);
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_watch_get_send_backlog(IntPtr raw, out UIntPtr bytes, out uint messages);

		public void GetSendBacklog(out ulong bytes, out uint messages) {
			UIntPtr native_bytes;
			gst_rtsp_watch_get_send_backlog(Handle, out native_bytes, out messages);
			bytes = (ulong) native_bytes;
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_watch_reset(IntPtr raw);

		public void Reset() {
			gst_rtsp_watch_reset(Handle);
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_watch_send_message(IntPtr raw, IntPtr message, out uint id);

		public Gst.Rtsp.RTSPResult SendMessage(Gst.Rtsp.RTSPMessage message, out uint id) {
			IntPtr native_message = GLib.Marshaller.StructureToPtrAlloc (message);
			int raw_ret = gst_rtsp_watch_send_message(Handle, native_message, out id);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			Marshal.FreeHGlobal (native_message);
			return ret;
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_watch_send_messages(IntPtr raw, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)]Gst.Rtsp.RTSPMessage[] messages, uint n_messages, out uint id);

		public Gst.Rtsp.RTSPResult SendMessages(Gst.Rtsp.RTSPMessage[] messages, out uint id) {
			uint n_messages = (uint)(messages == null ? 0 : messages.Length);
			int raw_ret = gst_rtsp_watch_send_messages(Handle, messages, n_messages, out id);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_watch_set_flushing(IntPtr raw, bool flushing);

		public bool Flushing { 
			set {
				gst_rtsp_watch_set_flushing(Handle, value);
			}
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_watch_set_send_backlog(IntPtr raw, UIntPtr bytes, uint messages);

		public void SetSendBacklog(ulong bytes, uint messages) {
			gst_rtsp_watch_set_send_backlog(Handle, new UIntPtr (bytes), messages);
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_watch_wait_backlog(IntPtr raw, IntPtr timeout);

		[Obsolete]
		public Gst.Rtsp.RTSPResult WaitBacklog(IntPtr timeout) {
			int raw_ret = gst_rtsp_watch_wait_backlog(Handle, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_watch_wait_backlog_usec(IntPtr raw, long timeout);

		public Gst.Rtsp.RTSPResult WaitBacklogUsec(long timeout) {
			int raw_ret = gst_rtsp_watch_wait_backlog_usec(Handle, timeout);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_rtsp_watch_write_data(IntPtr raw, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)]byte[] data, uint size, out uint id);

		public Gst.Rtsp.RTSPResult WriteData(byte[] data, out uint id) {
			uint size = (uint)(data == null ? 0 : data.Length);
			int raw_ret = gst_rtsp_watch_write_data(Handle, data, size, out id);
			Gst.Rtsp.RTSPResult ret = (Gst.Rtsp.RTSPResult) raw_ret;
			return ret;
		}

		public RTSPWatch(IntPtr raw) : base(raw) {}

		[DllImport("gstrtsp-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_rtsp_watch_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gst_rtsp_watch_unref (raw);
				Owned = false;
			}
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gst_rtsp_watch_unref;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
