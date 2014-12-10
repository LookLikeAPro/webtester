using System;
using Gtk;
using System.Net;
using System.Web;
using System.Text;
using System.Text.RegularExpressions;
//using Newtonsoft.Json;
namespace test
{
	class MainClass
	{
		public static void Main(string[] args) {
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();

			Application.Run ();
		}
	}
}
