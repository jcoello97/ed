<<<<<<< HEAD
using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		labelSaludo.Text = labelSaludo.Text + " " + entryNombre.Text;
	}
}
=======
﻿using System;
using Gtk;

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

	protected void OnButtonApplyClicked (object sender, EventArgs e)
	{
		labelSaludoFinal.Text = "Hola " + entryNom.Text;
	}
}
>>>>>>> a28a14d6b0af41a5511774f9b914dccd45c9e46b
