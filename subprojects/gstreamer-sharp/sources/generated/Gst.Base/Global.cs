// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Global {

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper(IntPtr src, ulong size);

		public static Gst.Caps TypeFindHelper(Gst.Pad src, ulong size) {
			IntPtr raw_ret = gst_type_find_helper(src == null ? IntPtr.Zero : src.Handle, size);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			return ret;
		}

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_for_buffer(IntPtr obj, IntPtr buf, out int prob);

		public static Gst.Caps TypeFindHelperForBuffer(Gst.Object obj, Gst.Buffer buf, out Gst.TypeFindProbability prob) {
			int native_prob;
			IntPtr raw_ret = gst_type_find_helper_for_buffer(obj == null ? IntPtr.Zero : obj.Handle, buf == null ? IntPtr.Zero : buf.Handle, out native_prob);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

		public static Gst.Caps TypeFindHelperForBuffer(Gst.Buffer buf, out Gst.TypeFindProbability prob) {
			return TypeFindHelperForBuffer (null, buf, out prob);
		}

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_for_buffer_with_extension(IntPtr obj, IntPtr buf, IntPtr extension, out int prob);

		public static Gst.Caps TypeFindHelperForBufferWithExtension(Gst.Object obj, Gst.Buffer buf, string extension, out Gst.TypeFindProbability prob) {
			IntPtr native_extension = GLib.Marshaller.StringToPtrGStrdup (extension);
			int native_prob;
			IntPtr raw_ret = gst_type_find_helper_for_buffer_with_extension(obj == null ? IntPtr.Zero : obj.Handle, buf == null ? IntPtr.Zero : buf.Handle, native_extension, out native_prob);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			GLib.Marshaller.Free (native_extension);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

		public static Gst.Caps TypeFindHelperForBufferWithExtension(Gst.Buffer buf, out Gst.TypeFindProbability prob) {
			return TypeFindHelperForBufferWithExtension (null, buf, null, out prob);
		}

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_for_data(IntPtr obj, byte[] data, UIntPtr size, out int prob);

		public static Gst.Caps TypeFindHelperForData(Gst.Object obj, byte[] data, ulong size, out Gst.TypeFindProbability prob) {
			int native_prob;
			IntPtr raw_ret = gst_type_find_helper_for_data(obj == null ? IntPtr.Zero : obj.Handle, data, new UIntPtr (size), out native_prob);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

		public static Gst.Caps TypeFindHelperForData(byte[] data, ulong size, out Gst.TypeFindProbability prob) {
			return TypeFindHelperForData (null, data, size, out prob);
		}

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_for_data_with_extension(IntPtr obj, byte[] data, UIntPtr size, IntPtr extension, out int prob);

		public static Gst.Caps TypeFindHelperForDataWithExtension(Gst.Object obj, byte[] data, ulong size, string extension, out Gst.TypeFindProbability prob) {
			IntPtr native_extension = GLib.Marshaller.StringToPtrGStrdup (extension);
			int native_prob;
			IntPtr raw_ret = gst_type_find_helper_for_data_with_extension(obj == null ? IntPtr.Zero : obj.Handle, data, new UIntPtr (size), native_extension, out native_prob);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			GLib.Marshaller.Free (native_extension);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

		public static Gst.Caps TypeFindHelperForDataWithExtension(byte[] data, ulong size, out Gst.TypeFindProbability prob) {
			return TypeFindHelperForDataWithExtension (null, data, size, null, out prob);
		}

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_for_extension(IntPtr obj, IntPtr extension);

		public static Gst.Caps TypeFindHelperForExtension(Gst.Object obj, string extension) {
			IntPtr native_extension = GLib.Marshaller.StringToPtrGStrdup (extension);
			IntPtr raw_ret = gst_type_find_helper_for_extension(obj == null ? IntPtr.Zero : obj.Handle, native_extension);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			GLib.Marshaller.Free (native_extension);
			return ret;
		}

		public static Gst.Caps TypeFindHelperForExtension(string extension) {
			return TypeFindHelperForExtension (null, extension);
		}

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_type_find_helper_get_range(IntPtr obj, IntPtr parent, Gst.BaseSharp.TypeFindHelperGetRangeFunctionNative func, ulong size, IntPtr extension, out int prob);

		public static Gst.Caps TypeFindHelperGetRange(Gst.Object obj, Gst.Object parent, Gst.Base.TypeFindHelperGetRangeFunction func, ulong size, string extension, out Gst.TypeFindProbability prob) {
			Gst.BaseSharp.TypeFindHelperGetRangeFunctionWrapper func_wrapper = new Gst.BaseSharp.TypeFindHelperGetRangeFunctionWrapper (func);
			IntPtr native_extension = GLib.Marshaller.StringToPtrGStrdup (extension);
			int native_prob;
			IntPtr raw_ret = gst_type_find_helper_get_range(obj == null ? IntPtr.Zero : obj.Handle, parent == null ? IntPtr.Zero : parent.Handle, func_wrapper.NativeDelegate, size, native_extension, out native_prob);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			GLib.Marshaller.Free (native_extension);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

		public static Gst.Caps TypeFindHelperGetRange(Gst.Object obj, Gst.Base.TypeFindHelperGetRangeFunction func, ulong size, out Gst.TypeFindProbability prob) {
			return TypeFindHelperGetRange (obj, null, func, size, null, out prob);
		}

		[DllImport("gstbase-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_type_find_helper_get_range_full(IntPtr obj, IntPtr parent, Gst.BaseSharp.TypeFindHelperGetRangeFunctionNative func, ulong size, IntPtr extension, out IntPtr caps, out int prob);

		public static Gst.FlowReturn TypeFindHelperGetRangeFull(Gst.Object obj, Gst.Object parent, Gst.Base.TypeFindHelperGetRangeFunction func, ulong size, string extension, out Gst.Caps caps, out Gst.TypeFindProbability prob) {
			Gst.BaseSharp.TypeFindHelperGetRangeFunctionWrapper func_wrapper = new Gst.BaseSharp.TypeFindHelperGetRangeFunctionWrapper (func);
			IntPtr native_extension = GLib.Marshaller.StringToPtrGStrdup (extension);
			IntPtr native_caps;
			int native_prob;
			int raw_ret = gst_type_find_helper_get_range_full(obj == null ? IntPtr.Zero : obj.Handle, parent == null ? IntPtr.Zero : parent.Handle, func_wrapper.NativeDelegate, size, native_extension, out native_caps, out native_prob);
			Gst.FlowReturn ret = (Gst.FlowReturn) raw_ret;
			GLib.Marshaller.Free (native_extension);
			caps = native_caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (native_caps, typeof (Gst.Caps), true);
			prob = (Gst.TypeFindProbability) native_prob;
			return ret;
		}

		public static Gst.FlowReturn TypeFindHelperGetRangeFull(Gst.Object obj, Gst.Base.TypeFindHelperGetRangeFunction func, ulong size, out Gst.Caps caps, out Gst.TypeFindProbability prob) {
			return TypeFindHelperGetRangeFull (obj, null, func, size, null, out caps, out prob);
		}

#endregion
	}
}
