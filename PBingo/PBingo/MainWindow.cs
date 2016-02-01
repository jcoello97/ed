using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();



		Table table = new Table (9,10,true);
		//OPCION 1:
		for (uint index=0; index<90; index++) 
		{
			uint fila = index / 10;
			uint columna = index % 10;
			Button button = new Button ();
			button.Label = (index+1).ToString;
			button.Visible = true;
			table.Attach(button,columna,columna+1,fila,fila+1);
		}


		table.Visible = true;
		vbox1.Add (table);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
