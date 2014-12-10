using System;
using Gtk;
using System.Net;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnEnter (object sender, EventArgs e)
	{
		log.Buffer.Text = search(url.Text);
	}

	protected void OnSearch (object sender, EventArgs e)
	{
		log.Buffer.Text = search(url.Text);
	}

	public string search(string input)
	{
		if (input.Length<7){
			input = input.Insert (0, "http://");
		}
		else if (input.Substring (0, 7) == "http://") {

		}
		else if (input.Substring (0, 8) == "https://") {

		}
		else {
			input = input.Insert (0, "http://");
		}
		var response = new WebClient().DownloadString(input);
		return response;
	}


}
