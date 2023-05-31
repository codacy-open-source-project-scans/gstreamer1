// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoMeta : IEquatable<VideoMeta> {

		public Gst.Meta Meta;
		private IntPtr _buffer;
		public Gst.Buffer Buffer {
			get {
				return _buffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (_buffer, typeof (Gst.Buffer), false);
			}
			set {
				_buffer = value == null ? IntPtr.Zero : value.Handle;
			}
		}
		public Gst.Video.VideoFrameFlags Flags;
		public Gst.Video.VideoFormat Format;
		public int Id;
		public uint Width;
		public uint Height;
		public uint NPlanes;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		public ulong[] Offset;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		public int[] Stride;
		private IntPtr _map;
		private IntPtr _unmap;
		public Gst.Video.VideoAlignment Alignment;

		public static Gst.Video.VideoMeta Zero = new Gst.Video.VideoMeta ();

		public static Gst.Video.VideoMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoMeta.Zero;
			return (Gst.Video.VideoMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoMeta));
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_meta_get_plane_height(IntPtr raw, out uint plane_height);

		public bool GetPlaneHeight(out uint plane_height) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_video_meta_get_plane_height(this_as_native, out plane_height);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_meta_get_plane_size(IntPtr raw, out UIntPtr plane_size);

		public bool GetPlaneSize(out ulong plane_size) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			UIntPtr native_plane_size;
			bool raw_ret = gst_video_meta_get_plane_size(this_as_native, out native_plane_size);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			plane_size = (ulong) native_plane_size;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_meta_map(IntPtr raw, uint plane, IntPtr info, out IntPtr data, out int stride, int flags);

		public bool Map(uint plane, Gst.MapInfo info, out IntPtr data, out int stride, Gst.MapFlags flags) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			bool raw_ret = gst_video_meta_map(this_as_native, plane, native_info, out data, out stride, (int) flags);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_info);
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_meta_set_alignment(IntPtr raw, IntPtr alignment);

		public bool SetAlignment(Gst.Video.VideoAlignment alignment) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_alignment = GLib.Marshaller.StructureToPtrAlloc (alignment);
			bool raw_ret = gst_video_meta_set_alignment(this_as_native, native_alignment);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_alignment);
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_meta_unmap(IntPtr raw, uint plane, IntPtr info);

		public bool Unmap(uint plane, Gst.MapInfo info) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			bool raw_ret = gst_video_meta_unmap(this_as_native, plane, native_info);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_info);
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		static void ReadNative (IntPtr native, ref Gst.Video.VideoMeta target)
		{
			target = New (native);
		}

		public bool Equals (VideoMeta other)
		{
			return true && Meta.Equals (other.Meta) && Buffer.Equals (other.Buffer) && Flags.Equals (other.Flags) && Format.Equals (other.Format) && Id.Equals (other.Id) && Width.Equals (other.Width) && Height.Equals (other.Height) && NPlanes.Equals (other.NPlanes) && Offset.Equals (other.Offset) && Stride.Equals (other.Stride) && _map.Equals (other._map) && _unmap.Equals (other._unmap) && Alignment.Equals (other.Alignment);
		}

		public override bool Equals (object other)
		{
			return other is VideoMeta && Equals ((VideoMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ Buffer.GetHashCode () ^ Flags.GetHashCode () ^ Format.GetHashCode () ^ Id.GetHashCode () ^ Width.GetHashCode () ^ Height.GetHashCode () ^ NPlanes.GetHashCode () ^ Offset.GetHashCode () ^ Stride.GetHashCode () ^ _map.GetHashCode () ^ _unmap.GetHashCode () ^ Alignment.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
