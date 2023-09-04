// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoRegionOfInterestMeta : IEquatable<VideoRegionOfInterestMeta> {

		public Gst.Meta Meta;
		public uint RoiType;
		public int Id;
		public int ParentId;
		public uint X;
		public uint Y;
		public uint W;
		public uint H;
		private IntPtr _parms;

		public static Gst.Video.VideoRegionOfInterestMeta Zero = new Gst.Video.VideoRegionOfInterestMeta ();

		public static Gst.Video.VideoRegionOfInterestMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoRegionOfInterestMeta.Zero;
			return (Gst.Video.VideoRegionOfInterestMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoRegionOfInterestMeta));
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_region_of_interest_meta_add_param(IntPtr raw, IntPtr s);

		public void AddParam(Gst.Structure s) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			s.Owned = false;
			gst_video_region_of_interest_meta_add_param(this_as_native, s == null ? IntPtr.Zero : s.Handle);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_region_of_interest_meta_get_param(IntPtr raw, IntPtr name);

		public Gst.Structure GetParam(string name) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_video_region_of_interest_meta_get_param(this_as_native, native_name);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_region_of_interest_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_region_of_interest_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		static void ReadNative (IntPtr native, ref Gst.Video.VideoRegionOfInterestMeta target)
		{
			target = New (native);
		}

		public bool Equals (VideoRegionOfInterestMeta other)
		{
			return true && Meta.Equals (other.Meta) && RoiType.Equals (other.RoiType) && Id.Equals (other.Id) && ParentId.Equals (other.ParentId) && X.Equals (other.X) && Y.Equals (other.Y) && W.Equals (other.W) && H.Equals (other.H) && _parms.Equals (other._parms);
		}

		public override bool Equals (object other)
		{
			return other is VideoRegionOfInterestMeta && Equals ((VideoRegionOfInterestMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ RoiType.GetHashCode () ^ Id.GetHashCode () ^ ParentId.GetHashCode () ^ X.GetHashCode () ^ Y.GetHashCode () ^ W.GetHashCode () ^ H.GetHashCode () ^ _parms.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
