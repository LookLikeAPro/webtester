
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.VBox vbox3;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView log;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Entry url;

	private global::Gtk.Button enter;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_File");
		w1.Add (this.FileAction, "1");
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Web Response Tester");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.log = new global::Gtk.TextView ();
		this.log.CanFocus = true;
		this.log.Name = "log";
		this.log.WrapMode = ((global::Gtk.WrapMode)(3));
		this.log.PixelsAboveLines = 2;
		this.log.PixelsBelowLines = 2;
		this.log.LeftMargin = 5;
		this.log.RightMargin = 5;
		this.GtkScrolledWindow.Add (this.log);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w3.Position = 1;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.url = new global::Gtk.Entry ();
		this.url.CanFocus = true;
		this.url.Name = "url";
		this.url.IsEditable = true;
		this.url.InvisibleChar = '●';
		this.hbox1.Add (this.url);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.url]));
		w4.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.enter = new global::Gtk.Button ();
		this.enter.CanFocus = true;
		this.enter.Name = "enter";
		this.enter.UseUnderline = true;
		this.enter.Label = global::Mono.Unix.Catalog.GetString ("Test");
		this.hbox1.Add (this.enter);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.enter]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.url.Activated += new global::System.EventHandler (this.OnEnter);
		this.enter.Clicked += new global::System.EventHandler (this.OnSearch);
	}
}
