// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ElementFactory : Gst.PluginFeature {

		public ElementFactory (IntPtr raw) : base(raw) {}

		protected ElementFactory() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gst.PluginFeature.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_element_factory_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_find(IntPtr name);

		public static Gst.ElementFactory Find(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_element_factory_find(native_name);
			Gst.ElementFactory ret = GLib.Object.GetObject(raw_ret, true) as Gst.ElementFactory;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_list_filter(IntPtr list, IntPtr caps, int direction, bool subsetonly);

		public static Gst.ElementFactory[] ListFilter(GLib.List list, Gst.Caps caps, Gst.PadDirection direction, bool subsetonly) {
			IntPtr raw_ret = gst_element_factory_list_filter(list == null ? IntPtr.Zero : list.Handle, caps == null ? IntPtr.Zero : caps.Handle, (int) direction, subsetonly);
			Gst.ElementFactory[] ret = (Gst.ElementFactory[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.ElementFactory));
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_list_get_elements(ulong type, int minrank);

		public static Gst.ElementFactory[] ListGetElements(ulong type, Gst.Rank minrank) {
			IntPtr raw_ret = gst_element_factory_list_get_elements(type, (int) minrank);
			Gst.ElementFactory[] ret = (Gst.ElementFactory[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(Gst.ElementFactory));
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_make(IntPtr factoryname, IntPtr name);

		public static Gst.Element Make(string factoryname, string name) {
			IntPtr native_factoryname = GLib.Marshaller.StringToPtrGStrdup (factoryname);
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_element_factory_make(native_factoryname, native_name);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.Free (native_factoryname);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		public static Gst.Element Make(string factoryname) {
			return Make (factoryname, null);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_make_with_properties(IntPtr factoryname, uint n, IntPtr names, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]IntPtr[] values);

		public static Gst.Element MakeWithProperties(string factoryname, string[] names, GLib.Value[] values) {
			IntPtr native_factoryname = GLib.Marshaller.StringToPtrGStrdup (factoryname);
			uint n = (uint)(names == null ? 0 : names.Length);
			IntPtr native_names = GLib.Marshaller.StringArrayToStrvPtr(names, false);
			IntPtr[] native_values = new IntPtr [n];
			for (int i = 0; i < n; i++)
				native_values [i] = GLib.Marshaller.StructureToPtrAlloc (values[i]);
			IntPtr raw_ret = gst_element_factory_make_with_properties(native_factoryname, n, native_names, native_values);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.Free (native_factoryname);
			GLib.Marshaller.StringArrayPtrFree (native_names, (int)n);
			for (int i = 0; i < native_values.Length; i++) {
				Marshal.FreeHGlobal (native_values[i]);
			}
			return ret;
		}

		public static Gst.Element MakeWithProperties(string factoryname) {
			return MakeWithProperties (factoryname, null, null);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_element_factory_can_sink_all_caps(IntPtr raw, IntPtr caps);

		public bool CanSinkAllCaps(Gst.Caps caps) {
			bool raw_ret = gst_element_factory_can_sink_all_caps(Handle, caps == null ? IntPtr.Zero : caps.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_element_factory_can_sink_any_caps(IntPtr raw, IntPtr caps);

		public bool CanSinkAnyCaps(Gst.Caps caps) {
			bool raw_ret = gst_element_factory_can_sink_any_caps(Handle, caps == null ? IntPtr.Zero : caps.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_element_factory_can_src_all_caps(IntPtr raw, IntPtr caps);

		public bool CanSrcAllCaps(Gst.Caps caps) {
			bool raw_ret = gst_element_factory_can_src_all_caps(Handle, caps == null ? IntPtr.Zero : caps.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_element_factory_can_src_any_caps(IntPtr raw, IntPtr caps);

		public bool CanSrcAnyCaps(Gst.Caps caps) {
			bool raw_ret = gst_element_factory_can_src_any_caps(Handle, caps == null ? IntPtr.Zero : caps.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_create(IntPtr raw, IntPtr name);

		public Gst.Element Create(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_element_factory_create(Handle, native_name);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		public Gst.Element Create() {
			return Create (null);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_create_with_properties(IntPtr raw, uint n, IntPtr names, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]IntPtr[] values);

		public Gst.Element CreateWithProperties(string[] names, GLib.Value[] values) {
			uint n = (uint)(names == null ? 0 : names.Length);
			IntPtr native_names = GLib.Marshaller.StringArrayToStrvPtr(names, false);
			IntPtr[] native_values = new IntPtr [n];
			for (int i = 0; i < n; i++)
				native_values [i] = GLib.Marshaller.StructureToPtrAlloc (values[i]);
			IntPtr raw_ret = gst_element_factory_create_with_properties(Handle, n, native_names, native_values);
			Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
			GLib.Marshaller.StringArrayPtrFree (native_names, (int)n);
			for (int i = 0; i < native_values.Length; i++) {
				Marshal.FreeHGlobal (native_values[i]);
			}
			return ret;
		}

		public Gst.Element CreateWithProperties() {
			return CreateWithProperties (null, null);
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_get_element_type(IntPtr raw);

		public GLib.GType ElementType { 
			get {
				IntPtr raw_ret = gst_element_factory_get_element_type(Handle);
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_get_metadata(IntPtr raw, IntPtr key);

		public string GetMetadata(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = gst_element_factory_get_metadata(Handle, native_key);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_get_metadata_keys(IntPtr raw);

		public string[] MetadataKeys { 
			get {
				IntPtr raw_ret = gst_element_factory_get_metadata_keys(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_element_factory_get_num_pad_templates(IntPtr raw);

		public uint NumPadTemplates { 
			get {
				uint raw_ret = gst_element_factory_get_num_pad_templates(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_element_factory_get_skip_documentation(IntPtr raw);

		public bool SkipDocumentation { 
			get {
				bool raw_ret = gst_element_factory_get_skip_documentation(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_element_factory_get_static_pad_templates(IntPtr raw);

		public Gst.StaticPadTemplate[] StaticPadTemplates { 
			get {
				IntPtr raw_ret = gst_element_factory_get_static_pad_templates(Handle);
				Gst.StaticPadTemplate[] ret = (Gst.StaticPadTemplate[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(Gst.StaticPadTemplate));
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_element_factory_get_uri_type(IntPtr raw);

		public Gst.URIType UriType { 
			get {
				int raw_ret = gst_element_factory_get_uri_type(Handle);
				Gst.URIType ret = (Gst.URIType) raw_ret;
				return ret;
			}
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_element_factory_has_interface(IntPtr raw, IntPtr interfacename);

		public bool HasInterface(string interfacename) {
			IntPtr native_interfacename = GLib.Marshaller.StringToPtrGStrdup (interfacename);
			bool raw_ret = gst_element_factory_has_interface(Handle, native_interfacename);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_interfacename);
			return ret;
		}

		[DllImport("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_element_factory_list_is_type(IntPtr raw, ulong type);

		public bool ListIsType(ulong type) {
			bool raw_ret = gst_element_factory_list_is_type(Handle, type);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.PluginFeature.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
