// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Container : GES.TimelineElement {

		protected Container (IntPtr raw) : base(raw) {}

		protected Container() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("height")]
		public uint Height {
			get {
				GLib.Value val = GetProperty ("height");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		public GLib.List Children {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("children"));
					return new GLib.List((*raw_ptr));
				}
			}
		}

		public uint HeightField {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("height"));
					return (*raw_ptr);
				}
			}
		}

		public GES.ChildrenControlMode ChildrenControlMode {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("children_control_mode"));
					return (GES.ChildrenControlMode) (*raw_ptr);
				}
			}
		}

		public GES.TimelineElement InitiatedMove {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("initiated_move"));
					return GLib.Object.GetObject((*raw_ptr)) as GES.TimelineElement;
				}
			}
		}

		[GLib.Signal("child-added")]
		public event GES.ChildAddedHandler ChildAdded {
			add {
				this.AddSignalHandler ("child-added", value, typeof (GES.ChildAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("child-added", value);
			}
		}

		[GLib.Signal("child-removed")]
		public event GES.ChildRemovedHandler ChildRemoved {
			add {
				this.AddSignalHandler ("child-removed", value, typeof (GES.ChildRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("child-removed", value);
			}
		}

		static ChildAddedNativeDelegate ChildAdded_cb_delegate;
		static ChildAddedNativeDelegate ChildAddedVMCallback {
			get {
				if (ChildAdded_cb_delegate == null)
					ChildAdded_cb_delegate = new ChildAddedNativeDelegate (ChildAdded_cb);
				return ChildAdded_cb_delegate;
			}
		}

		static void OverrideChildAdded (GLib.GType gtype)
		{
			OverrideChildAdded (gtype, ChildAddedVMCallback);
		}

		static void OverrideChildAdded (GLib.GType gtype, ChildAddedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("child_added"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChildAddedNativeDelegate (IntPtr inst, IntPtr element);

		static void ChildAdded_cb (IntPtr inst, IntPtr element)
		{
			try {
				Container __obj = GLib.Object.GetObject (inst, false) as Container;
				__obj.OnChildAdded (GLib.Object.GetObject(element) as GES.TimelineElement);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Container), ConnectionMethod="OverrideChildAdded")]
		protected virtual void OnChildAdded (GES.TimelineElement element)
		{
			InternalChildAdded (element);
		}

		private void InternalChildAdded (GES.TimelineElement element)
		{
			ChildAddedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("child_added"));
				unmanaged = (ChildAddedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChildAddedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, element == null ? IntPtr.Zero : element.Handle);
		}

		static ChildRemovedNativeDelegate ChildRemoved_cb_delegate;
		static ChildRemovedNativeDelegate ChildRemovedVMCallback {
			get {
				if (ChildRemoved_cb_delegate == null)
					ChildRemoved_cb_delegate = new ChildRemovedNativeDelegate (ChildRemoved_cb);
				return ChildRemoved_cb_delegate;
			}
		}

		static void OverrideChildRemoved (GLib.GType gtype)
		{
			OverrideChildRemoved (gtype, ChildRemovedVMCallback);
		}

		static void OverrideChildRemoved (GLib.GType gtype, ChildRemovedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("child_removed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChildRemovedNativeDelegate (IntPtr inst, IntPtr element);

		static void ChildRemoved_cb (IntPtr inst, IntPtr element)
		{
			try {
				Container __obj = GLib.Object.GetObject (inst, false) as Container;
				__obj.OnChildRemoved (GLib.Object.GetObject(element) as GES.TimelineElement);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Container), ConnectionMethod="OverrideChildRemoved")]
		protected virtual void OnChildRemoved (GES.TimelineElement element)
		{
			InternalChildRemoved (element);
		}

		private void InternalChildRemoved (GES.TimelineElement element)
		{
			ChildRemovedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("child_removed"));
				unmanaged = (ChildRemovedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChildRemovedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, element == null ? IntPtr.Zero : element.Handle);
		}

		static AddChildNativeDelegate AddChild_cb_delegate;
		static AddChildNativeDelegate AddChildVMCallback {
			get {
				if (AddChild_cb_delegate == null)
					AddChild_cb_delegate = new AddChildNativeDelegate (AddChild_cb);
				return AddChild_cb_delegate;
			}
		}

		static void OverrideAddChild (GLib.GType gtype)
		{
			OverrideAddChild (gtype, AddChildVMCallback);
		}

		static void OverrideAddChild (GLib.GType gtype, AddChildNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("add_child"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool AddChildNativeDelegate (IntPtr inst, IntPtr element);

		static bool AddChild_cb (IntPtr inst, IntPtr element)
		{
			try {
				Container __obj = GLib.Object.GetObject (inst, false) as Container;
				bool __result;
				__result = __obj.OnAddChild (GLib.Object.GetObject(element) as GES.TimelineElement);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Container), ConnectionMethod="OverrideAddChild")]
		protected virtual bool OnAddChild (GES.TimelineElement element)
		{
			return InternalAddChild (element);
		}

		private bool InternalAddChild (GES.TimelineElement element)
		{
			AddChildNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("add_child"));
				unmanaged = (AddChildNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(AddChildNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, element == null ? IntPtr.Zero : element.Handle);
			return __result;
		}

		static RemoveChildNativeDelegate RemoveChild_cb_delegate;
		static RemoveChildNativeDelegate RemoveChildVMCallback {
			get {
				if (RemoveChild_cb_delegate == null)
					RemoveChild_cb_delegate = new RemoveChildNativeDelegate (RemoveChild_cb);
				return RemoveChild_cb_delegate;
			}
		}

		static void OverrideRemoveChild (GLib.GType gtype)
		{
			OverrideRemoveChild (gtype, RemoveChildVMCallback);
		}

		static void OverrideRemoveChild (GLib.GType gtype, RemoveChildNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("remove_child"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool RemoveChildNativeDelegate (IntPtr inst, IntPtr element);

		static bool RemoveChild_cb (IntPtr inst, IntPtr element)
		{
			try {
				Container __obj = GLib.Object.GetObject (inst, false) as Container;
				bool __result;
				__result = __obj.OnRemoveChild (GLib.Object.GetObject(element) as GES.TimelineElement);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Container), ConnectionMethod="OverrideRemoveChild")]
		protected virtual bool OnRemoveChild (GES.TimelineElement element)
		{
			return InternalRemoveChild (element);
		}

		private bool InternalRemoveChild (GES.TimelineElement element)
		{
			RemoveChildNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("remove_child"));
				unmanaged = (RemoveChildNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(RemoveChildNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, element == null ? IntPtr.Zero : element.Handle);
			return __result;
		}

		static UngroupNativeDelegate Ungroup_cb_delegate;
		static UngroupNativeDelegate UngroupVMCallback {
			get {
				if (Ungroup_cb_delegate == null)
					Ungroup_cb_delegate = new UngroupNativeDelegate (Ungroup_cb);
				return Ungroup_cb_delegate;
			}
		}

		static void OverrideUngroup (GLib.GType gtype)
		{
			OverrideUngroup (gtype, UngroupVMCallback);
		}

		static void OverrideUngroup (GLib.GType gtype, UngroupNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("ungroup"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr UngroupNativeDelegate (IntPtr inst, bool recursive);

		static IntPtr Ungroup_cb (IntPtr inst, bool recursive)
		{
			try {
				Container __obj = GLib.Object.GetObject (inst, false) as Container;
				GES.Container[] __result;
				__result = __obj.OnUngroup (recursive);
				return new GLib.List(__result, typeof (GES.Container), true, true) == null ? IntPtr.Zero : new GLib.List(__result, typeof (GES.Container), true, true).Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Container), ConnectionMethod="OverrideUngroup")]
		protected virtual GES.Container[] OnUngroup (bool recursive)
		{
			return InternalUngroup (recursive);
		}

		private GES.Container[] InternalUngroup (bool recursive)
		{
			UngroupNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("ungroup"));
				unmanaged = (UngroupNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(UngroupNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, recursive);
			return (GES.Container[]) GLib.Marshaller.ListPtrToArray (__result, typeof(GLib.List), true, true, typeof(GES.Container));
		}

		static EditNativeDelegate Edit_cb_delegate;
		static EditNativeDelegate EditVMCallback {
			get {
				if (Edit_cb_delegate == null)
					Edit_cb_delegate = new EditNativeDelegate (Edit_cb);
				return Edit_cb_delegate;
			}
		}

		static void OverrideEdit (GLib.GType gtype)
		{
			OverrideEdit (gtype, EditVMCallback);
		}

		static void OverrideEdit (GLib.GType gtype, EditNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("edit"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool EditNativeDelegate (IntPtr inst, IntPtr layers, int new_layer_priority, int mode, int edge, ulong position);

		static bool Edit_cb (IntPtr inst, IntPtr layers, int new_layer_priority, int mode, int edge, ulong position)
		{
			try {
				Container __obj = GLib.Object.GetObject (inst, false) as Container;
				bool __result;
				__result = __obj.OnEdit (new GLib.List(layers), new_layer_priority, (GES.EditMode) mode, (GES.Edge) edge, position);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Container), ConnectionMethod="OverrideEdit")]
		protected virtual bool OnEdit (GLib.List layers, int new_layer_priority, GES.EditMode mode, GES.Edge edge, ulong position)
		{
			return InternalEdit (layers, new_layer_priority, mode, edge, position);
		}

		private bool InternalEdit (GLib.List layers, int new_layer_priority, GES.EditMode mode, GES.Edge edge, ulong position)
		{
			EditNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("edit"));
				unmanaged = (EditNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(EditNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, layers == null ? IntPtr.Zero : layers.Handle, new_layer_priority, (int) mode, (int) edge, position);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("child_added"
							, GES.TimelineElement.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // child_added
							, null
							, "child_removed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("child_removed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // child_removed
							, "child_added"
							, "add_child"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("add_child"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // add_child
							, "child_removed"
							, "remove_child"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("remove_child"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // remove_child
							, "add_child"
							, "ungroup"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("ungroup"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // ungroup
							, "remove_child"
							, "group"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("group"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // group
							, "ungroup"
							, "edit"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("edit"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // edit
							, "group"
							, "grouping_priority"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("grouping_priority"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // grouping_priority
							, "edit"
							, "_ges_reserved"
							, (long) Marshal.OffsetOf(typeof(GESContainer_grouping_priorityAlign), "grouping_priority")
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _ges_reserved
							, "grouping_priority"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GESContainer_grouping_priorityAlign
		{
			sbyte f1;
			private uint grouping_priority;
		}


		// End of the ABI representation.

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_container_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_container_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_container_group(IntPtr containers);

		public static GES.Container Group(GLib.List containers) {
			IntPtr raw_ret = ges_container_group(containers == null ? IntPtr.Zero : containers.Handle);
			GES.Container ret = GLib.Object.GetObject(raw_ret) as GES.Container;
			return ret;
		}

		public static GES.Container Group() {
			return Group (null);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_container_add(IntPtr raw, IntPtr child);

		public bool Add(GES.TimelineElement child) {
			bool raw_ret = ges_container_add(Handle, child == null ? IntPtr.Zero : child.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_container_edit(IntPtr raw, IntPtr layers, int new_layer_priority, int mode, int edge, ulong position);

		[Obsolete]
		public bool Edit(GLib.List layers, int new_layer_priority, GES.EditMode mode, GES.Edge edge, ulong position) {
			bool raw_ret = ges_container_edit(Handle, layers == null ? IntPtr.Zero : layers.Handle, new_layer_priority, (int) mode, (int) edge, position);
			bool ret = raw_ret;
			return ret;
		}

		public bool Edit(int new_layer_priority, GES.EditMode mode, GES.Edge edge, ulong position) {
			return Edit (null, new_layer_priority, mode, edge, position);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_container_get_children(IntPtr raw, bool recursive);

		public GES.TimelineElement[] GetChildren(bool recursive) {
			IntPtr raw_ret = ges_container_get_children(Handle, recursive);
			GES.TimelineElement[] ret = (GES.TimelineElement[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GES.TimelineElement));
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_container_remove(IntPtr raw, IntPtr child);

		public bool Remove(GES.TimelineElement child) {
			bool raw_ret = ges_container_remove(Handle, child == null ? IntPtr.Zero : child.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_container_ungroup(IntPtr raw, bool recursive);

		public GES.Container[] Ungroup(bool recursive) {
			IntPtr raw_ret = ges_container_ungroup(Handle, recursive);
			GES.Container[] ret = (GES.Container[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GES.Container));
			return ret;
		}


		static Container ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("children"
							, GES.TimelineElement.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // children
							, null
							, "height"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("height"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // height
							, "children"
							, "children_control_mode"
							, (long) Marshal.OffsetOf(typeof(GESContainer_heightAlign), "height")
							, 0
							),
						new GLib.AbiField("children_control_mode"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(GES.ChildrenControlMode))) // children_control_mode
							, "height"
							, "initiated_move"
							, (long) Marshal.OffsetOf(typeof(GESContainer_children_control_modeAlign), "children_control_mode")
							, 0
							),
						new GLib.AbiField("initiated_move"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // initiated_move
							, "children_control_mode"
							, "priv"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "initiated_move"
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _ges_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GESContainer_heightAlign
		{
			sbyte f1;
			private uint height;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GESContainer_children_control_modeAlign
		{
			sbyte f1;
			private GES.ChildrenControlMode children_control_mode;
		}


		// End of the ABI representation.

#endregion
	}
}
