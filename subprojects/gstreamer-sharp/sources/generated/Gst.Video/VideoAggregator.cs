// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VideoAggregator : Gst.Base.Aggregator {

		protected VideoAggregator (IntPtr raw) : base(raw) {}

		protected VideoAggregator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		public Gst.Video.VideoInfo Info {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("info"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Video.VideoInfo), false);
				}
			}
		}

		static UpdateCapsNativeDelegate UpdateCaps_cb_delegate;
		static UpdateCapsNativeDelegate UpdateCapsVMCallback {
			get {
				if (UpdateCaps_cb_delegate == null)
					UpdateCaps_cb_delegate = new UpdateCapsNativeDelegate (UpdateCaps_cb);
				return UpdateCaps_cb_delegate;
			}
		}

		static void OverrideUpdateCaps (GLib.GType gtype)
		{
			OverrideUpdateCaps (gtype, UpdateCapsVMCallback);
		}

		static void OverrideUpdateCaps (GLib.GType gtype, UpdateCapsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("update_caps"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr UpdateCapsNativeDelegate (IntPtr inst, IntPtr caps);

		static IntPtr UpdateCaps_cb (IntPtr inst, IntPtr caps)
		{
			try {
				VideoAggregator __obj = GLib.Object.GetObject (inst, false) as VideoAggregator;
				Gst.Caps __result;
				__result = __obj.OnUpdateCaps (caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (caps, typeof (Gst.Caps), false));
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Video.VideoAggregator), ConnectionMethod="OverrideUpdateCaps")]
		protected virtual Gst.Caps OnUpdateCaps (Gst.Caps caps)
		{
			return InternalUpdateCaps (caps);
		}

		private Gst.Caps InternalUpdateCaps (Gst.Caps caps)
		{
			UpdateCapsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("update_caps"));
				unmanaged = (UpdateCapsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(UpdateCapsNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, caps == null ? IntPtr.Zero : caps.Handle);
			return __result == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (__result, typeof (Gst.Caps), true);
		}

		static AggregateFramesNativeDelegate AggregateFrames_cb_delegate;
		static AggregateFramesNativeDelegate AggregateFramesVMCallback {
			get {
				if (AggregateFrames_cb_delegate == null)
					AggregateFrames_cb_delegate = new AggregateFramesNativeDelegate (AggregateFrames_cb);
				return AggregateFrames_cb_delegate;
			}
		}

		static void OverrideAggregateFrames (GLib.GType gtype)
		{
			OverrideAggregateFrames (gtype, AggregateFramesVMCallback);
		}

		static void OverrideAggregateFrames (GLib.GType gtype, AggregateFramesNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("aggregate_frames"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int AggregateFramesNativeDelegate (IntPtr inst, IntPtr outbuffer);

		static int AggregateFrames_cb (IntPtr inst, IntPtr outbuffer)
		{
			try {
				VideoAggregator __obj = GLib.Object.GetObject (inst, false) as VideoAggregator;
				Gst.FlowReturn __result;
				__result = __obj.OnAggregateFrames (outbuffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (outbuffer, typeof (Gst.Buffer), false));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Video.VideoAggregator), ConnectionMethod="OverrideAggregateFrames")]
		protected virtual Gst.FlowReturn OnAggregateFrames (Gst.Buffer outbuffer)
		{
			return InternalAggregateFrames (outbuffer);
		}

		private Gst.FlowReturn InternalAggregateFrames (Gst.Buffer outbuffer)
		{
			AggregateFramesNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("aggregate_frames"));
				unmanaged = (AggregateFramesNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AggregateFramesNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			int __result = unmanaged (this.Handle, outbuffer == null ? IntPtr.Zero : outbuffer.Handle);
			return (Gst.FlowReturn) __result;
		}

		static CreateOutputBufferNativeDelegate CreateOutputBuffer_cb_delegate;
		static CreateOutputBufferNativeDelegate CreateOutputBufferVMCallback {
			get {
				if (CreateOutputBuffer_cb_delegate == null)
					CreateOutputBuffer_cb_delegate = new CreateOutputBufferNativeDelegate (CreateOutputBuffer_cb);
				return CreateOutputBuffer_cb_delegate;
			}
		}

		static void OverrideCreateOutputBuffer (GLib.GType gtype)
		{
			OverrideCreateOutputBuffer (gtype, CreateOutputBufferVMCallback);
		}

		static void OverrideCreateOutputBuffer (GLib.GType gtype, CreateOutputBufferNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("create_output_buffer"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int CreateOutputBufferNativeDelegate (IntPtr inst, IntPtr outbuffer);

		static int CreateOutputBuffer_cb (IntPtr inst, IntPtr outbuffer)
		{
			try {
				VideoAggregator __obj = GLib.Object.GetObject (inst, false) as VideoAggregator;
				Gst.FlowReturn __result;
				__result = __obj.OnCreateOutputBuffer (outbuffer == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (outbuffer, typeof (Gst.Buffer), false));
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Video.VideoAggregator), ConnectionMethod="OverrideCreateOutputBuffer")]
		protected virtual Gst.FlowReturn OnCreateOutputBuffer (Gst.Buffer outbuffer)
		{
			return InternalCreateOutputBuffer (outbuffer);
		}

		private Gst.FlowReturn InternalCreateOutputBuffer (Gst.Buffer outbuffer)
		{
			CreateOutputBufferNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("create_output_buffer"));
				unmanaged = (CreateOutputBufferNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CreateOutputBufferNativeDelegate));
			}
			if (unmanaged == null) return (Gst.FlowReturn) 0;

			int __result = unmanaged (this.Handle, outbuffer == null ? IntPtr.Zero : outbuffer.Handle);
			return (Gst.FlowReturn) __result;
		}

		static FindBestFormatNativeDelegate FindBestFormat_cb_delegate;
		static FindBestFormatNativeDelegate FindBestFormatVMCallback {
			get {
				if (FindBestFormat_cb_delegate == null)
					FindBestFormat_cb_delegate = new FindBestFormatNativeDelegate (FindBestFormat_cb);
				return FindBestFormat_cb_delegate;
			}
		}

		static void OverrideFindBestFormat (GLib.GType gtype)
		{
			OverrideFindBestFormat (gtype, FindBestFormatVMCallback);
		}

		static void OverrideFindBestFormat (GLib.GType gtype, FindBestFormatNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("find_best_format"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void FindBestFormatNativeDelegate (IntPtr inst, IntPtr downstream_caps, IntPtr best_info, bool at_least_one_alpha);

		static void FindBestFormat_cb (IntPtr inst, IntPtr downstream_caps, IntPtr best_info, bool at_least_one_alpha)
		{
			try {
				VideoAggregator __obj = GLib.Object.GetObject (inst, false) as VideoAggregator;
				__obj.OnFindBestFormat (downstream_caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (downstream_caps, typeof (Gst.Caps), false), best_info == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque (best_info, typeof (Gst.Video.VideoInfo), false), at_least_one_alpha);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Video.VideoAggregator), ConnectionMethod="OverrideFindBestFormat")]
		protected virtual void OnFindBestFormat (Gst.Caps downstream_caps, Gst.Video.VideoInfo best_info, bool at_least_one_alpha)
		{
			InternalFindBestFormat (downstream_caps, best_info, at_least_one_alpha);
		}

		private void InternalFindBestFormat (Gst.Caps downstream_caps, Gst.Video.VideoInfo best_info, bool at_least_one_alpha)
		{
			FindBestFormatNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("find_best_format"));
				unmanaged = (FindBestFormatNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FindBestFormatNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, downstream_caps == null ? IntPtr.Zero : downstream_caps.Handle, best_info == null ? IntPtr.Zero : best_info.Handle, at_least_one_alpha);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("update_caps"
							, Gst.Base.Aggregator.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // update_caps
							, null
							, "aggregate_frames"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("aggregate_frames"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // aggregate_frames
							, "update_caps"
							, "create_output_buffer"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("create_output_buffer"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // create_output_buffer
							, "aggregate_frames"
							, "find_best_format"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("find_best_format"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // find_best_format
							, "create_output_buffer"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _gst_reserved
							, "find_best_format"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_aggregator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_aggregator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static VideoAggregator ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("info"
							, Gst.Base.Aggregator.abi_info.Fields
							, Gst.Video.VideoInfo.abi_info.Size // info
							, null
							, "priv"
							, Gst.Video.VideoInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "info"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _gst_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
