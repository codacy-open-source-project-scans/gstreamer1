// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;

	public delegate void DeepElementAddedHandler(object o, DeepElementAddedArgs args);

	public class DeepElementAddedArgs : GLib.SignalArgs {
		public Gst.Bin SubBin{
			get {
				return (Gst.Bin) Args [0];
			}
		}

		public Gst.Element Element{
			get {
				return (Gst.Element) Args [1];
			}
		}

	}
}
