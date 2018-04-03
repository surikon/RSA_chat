using System;
using Gtk;
using System.Threading.Tasks;

namespace CHAT_RSA
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();

			Task updateChat = new Task (win.setSomeText);
			updateChat.Start ();
		
			win.Show ();
			Application.Run ();
		}
	}
}
