<<<<<<< HEAD
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
=======
﻿using System;
using Gtk;
using System.Diagnostics;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{
	private Random random;
	private readonly Gdk.Color GREEN_COLOR = new Gdk.Color(0,255,0);
	private Table table;
	private List<int> numeros;
	private List<Button> buttons;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		random = new Random ();
		table = new Table (9,10,true);
		numeros = new List<int> ();
		buttons = new List<Button> ();

		for (uint i = 0; i < 99; i++)
		{
			uint fila = i / 10;
			uint col = i % 10;
			int numero = (int)i + 1;
			addButton (numero, fila, col);
			numeros.Add (numero);
		}


		table.Visible = true;
		vbox3.Add (table);

		buttonNumero.Clicked += delegate {
			int numero = getNumero ();
			show (numero);
			espeak (numero);
			buttonNumero.Sensitive = numeros.Count > 0;
		};

	}
	private int getNumero()
	{
		int indexAleat = random.Next (numeros.Count);
		int numero = numeros [indexAleat];
		numeros.RemoveAt (indexAleat);
		return numero;
	}
	private void show(int numero)
	{
		labelNum.Text = numero.ToString ();
		Button button = buttons [numero - 1];
		button.ModifyBg (StateType.Normal, GREEN_COLOR);
	}
	private void espeak(int numero)
	{
		string text = numero.ToString ();
		if (text.Length == 2) 
		{
			text=string.Format("\"{0}{1}{2}\"", text, text[0],text[1]);
		}
		Process.Start ("espeak","-v es "+ text);
	}
	private void addButton(int numero, uint fila, uint col) {
		Button button = new Button ();
		button.Label = numero.ToString();
		button.Visible = true;
		table.Attach (button, col, col + 1, fila, fila + 1);
		buttons.Add (button);
	}




	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
		
}
>>>>>>> a28a14d6b0af41a5511774f9b914dccd45c9e46b
