// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class WebRTCICETransport : Gst.Object {

		protected WebRTCICETransport (IntPtr raw) : base(raw) {}

		protected WebRTCICETransport() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("component")]
		public Gst.WebRTC.WebRTCICEComponent Component {
			get {
				GLib.Value val = GetProperty ("component");
				Gst.WebRTC.WebRTCICEComponent ret = (Gst.WebRTC.WebRTCICEComponent) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("gathering-state")]
		public Gst.WebRTC.WebRTCICEGatheringState GatheringState {
			get {
				GLib.Value val = GetProperty ("gathering-state");
				Gst.WebRTC.WebRTCICEGatheringState ret = (Gst.WebRTC.WebRTCICEGatheringState) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("state")]
		public Gst.WebRTC.WebRTCICEConnectionState State {
			get {
				GLib.Value val = GetProperty ("state");
				Gst.WebRTC.WebRTCICEConnectionState ret = (Gst.WebRTC.WebRTCICEConnectionState) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("on-selected-candidate-pair-change")]
		public event System.EventHandler OnSelectedCandidatePairChange {
			add {
				this.AddSignalHandler ("on-selected-candidate-pair-change", value);
			}
			remove {
				this.RemoveSignalHandler ("on-selected-candidate-pair-change", value);
			}
		}

		[GLib.Signal("on-new-candidate")]
		public event Gst.WebRTC.OnNewCandidateHandler OnNewCandidate {
			add {
				this.AddSignalHandler ("on-new-candidate", value, typeof (Gst.WebRTC.OnNewCandidateArgs));
			}
			remove {
				this.RemoveSignalHandler ("on-new-candidate", value);
			}
		}

		static OnNewCandidateNativeDelegate OnNewCandidate_cb_delegate;
		static OnNewCandidateNativeDelegate OnNewCandidateVMCallback {
			get {
				if (OnNewCandidate_cb_delegate == null)
					OnNewCandidate_cb_delegate = new OnNewCandidateNativeDelegate (OnNewCandidate_cb);
				return OnNewCandidate_cb_delegate;
			}
		}

		static void OverrideOnNewCandidate (GLib.GType gtype)
		{
			OverrideOnNewCandidate (gtype, OnNewCandidateVMCallback);
		}

		static void OverrideOnNewCandidate (GLib.GType gtype, OnNewCandidateNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "on-new-candidate", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OnNewCandidateNativeDelegate (IntPtr inst, IntPtr _object);

		static void OnNewCandidate_cb (IntPtr inst, IntPtr _object)
		{
			try {
				WebRTCICETransport __obj = GLib.Object.GetObject (inst, false) as WebRTCICETransport;
				__obj.OnOnNewCandidate (GLib.Marshaller.Utf8PtrToString (_object));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCICETransport), ConnectionMethod="OverrideOnNewCandidate")]
		protected virtual void OnOnNewCandidate (string _object)
		{
			InternalOnNewCandidate (_object);
		}

		private void InternalOnNewCandidate (string _object)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (_object);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static OnSelectedCandidatePairChangeNativeDelegate OnSelectedCandidatePairChange_cb_delegate;
		static OnSelectedCandidatePairChangeNativeDelegate OnSelectedCandidatePairChangeVMCallback {
			get {
				if (OnSelectedCandidatePairChange_cb_delegate == null)
					OnSelectedCandidatePairChange_cb_delegate = new OnSelectedCandidatePairChangeNativeDelegate (OnSelectedCandidatePairChange_cb);
				return OnSelectedCandidatePairChange_cb_delegate;
			}
		}

		static void OverrideOnSelectedCandidatePairChange (GLib.GType gtype)
		{
			OverrideOnSelectedCandidatePairChange (gtype, OnSelectedCandidatePairChangeVMCallback);
		}

		static void OverrideOnSelectedCandidatePairChange (GLib.GType gtype, OnSelectedCandidatePairChangeNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "on-selected-candidate-pair-change", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OnSelectedCandidatePairChangeNativeDelegate (IntPtr inst);

		static void OnSelectedCandidatePairChange_cb (IntPtr inst)
		{
			try {
				WebRTCICETransport __obj = GLib.Object.GetObject (inst, false) as WebRTCICETransport;
				__obj.OnOnSelectedCandidatePairChange ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.WebRTC.WebRTCICETransport), ConnectionMethod="OverrideOnSelectedCandidatePairChange")]
		protected virtual void OnOnSelectedCandidatePairChange ()
		{
			InternalOnSelectedCandidatePairChange ();
		}

		private void InternalOnSelectedCandidatePairChange ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gst.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_ice_transport_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_webrtc_ice_transport_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static WebRTCICETransport ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
