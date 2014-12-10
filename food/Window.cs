using System;

namespace test
{
	public partial class Window : Gtk.Window
	{
		public Window () : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

		}
		public void lol (object sender, EventArgs args)
		{
			log.Buffer.Text = "test";

		}
	}
}

