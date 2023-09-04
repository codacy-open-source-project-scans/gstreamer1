// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Poll : GLib.Opaque {

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_add_fd(IntPtr raw, IntPtr fd);

		public bool AddFd(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_add_fd(Handle, native_fd);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_can_read(IntPtr raw, IntPtr fd);

		public bool FdCanRead(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_can_read(Handle, native_fd);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_can_write(IntPtr raw, IntPtr fd);

		public bool FdCanWrite(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_can_write(Handle, native_fd);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_ctl_pri(IntPtr raw, IntPtr fd, bool active);

		public bool FdCtlPri(Gst.PollFD fd, bool active) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_ctl_pri(Handle, native_fd, active);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_ctl_read(IntPtr raw, IntPtr fd, bool active);

		public bool FdCtlRead(Gst.PollFD fd, bool active) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_ctl_read(Handle, native_fd, active);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_ctl_write(IntPtr raw, IntPtr fd, bool active);

		public bool FdCtlWrite(Gst.PollFD fd, bool active) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_ctl_write(Handle, native_fd, active);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_has_closed(IntPtr raw, IntPtr fd);

		public bool FdHasClosed(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_has_closed(Handle, native_fd);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_has_error(IntPtr raw, IntPtr fd);

		public bool FdHasError(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_has_error(Handle, native_fd);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_fd_has_pri(IntPtr raw, IntPtr fd);

		public bool FdHasPri(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_fd_has_pri(Handle, native_fd);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_poll_fd_ignored(IntPtr raw, IntPtr fd);

		public void FdIgnored(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			gst_poll_fd_ignored(Handle, native_fd);
			Marshal.FreeHGlobal (native_fd);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_poll_get_read_gpollfd(IntPtr raw, out GLib.PollFD fd);

		public GLib.PollFD ReadGpollfd { 
			get {
				GLib.PollFD fd;
				gst_poll_get_read_gpollfd(Handle, out fd);
				return fd;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_read_control(IntPtr raw);

		public bool ReadControl() {
			bool raw_ret = gst_poll_read_control(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_remove_fd(IntPtr raw, IntPtr fd);

		public bool RemoveFd(Gst.PollFD fd) {
			IntPtr native_fd = GLib.Marshaller.StructureToPtrAlloc (fd);
			bool raw_ret = gst_poll_remove_fd(Handle, native_fd);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_fd);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_poll_restart(IntPtr raw);

		public void Restart() {
			gst_poll_restart(Handle);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_set_controllable(IntPtr raw, bool controllable);

		public bool SetControllable(bool controllable) {
			bool raw_ret = gst_poll_set_controllable(Handle, controllable);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_poll_set_flushing(IntPtr raw, bool flushing);

		public bool Flushing { 
			set {
				gst_poll_set_flushing(Handle, value);
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_poll_wait(IntPtr raw, ulong timeout);

		public int Wait(ulong timeout) {
			int raw_ret = gst_poll_wait(Handle, timeout);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_poll_write_control(IntPtr raw);

		public bool WriteControl() {
			bool raw_ret = gst_poll_write_control(Handle);
			bool ret = raw_ret;
			return ret;
		}

		public Poll(IntPtr raw) : base(raw) {}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_poll_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_poll_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gst_poll_free;
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
