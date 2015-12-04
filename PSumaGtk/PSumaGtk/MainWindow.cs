using System;
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

	protected void ButtonClickedSuma (object sender, EventArgs e)
	{
		decimal numero1 = decimal.Parse (entryNum1.Text);
		decimal numero2 = decimal.Parse (entryNum1.Text);
		decimal resultadoSuma = numero1 + numero2;
		labelResult.Text = resultadoSuma.ToString ();		
	}

	protected void ButtonClickedRestar (object sender, EventArgs e)
	{
		decimal numero1 = decimal.Parse (entryNum1.Text);
		decimal numero2 = decimal.Parse (entryNum1.Text);
		decimal resultadoResta = numero1 - numero2;
		labelResult.Text = resultadoResta.ToString ();	
	}

	protected void ButtonClickedDividir (object sender, EventArgs e)
	{
		decimal numero1 = decimal.Parse (entryNum1.Text);
		decimal numero2 = decimal.Parse (entryNum1.Text);
		decimal resultadoDividir = numero1 / numero2;
		labelResult.Text = resultadoDividir.ToString ();	
	}

	protected void ButtonClickedMultiplicar (object sender, EventArgs e)
	{
		decimal numero1 = decimal.Parse (entryNum1.Text);
		decimal numero2 = decimal.Parse (entryNum1.Text);
		decimal resultadoMultiplicar = numero1 * numero2;
		labelResult.Text = resultadoMultiplicar.ToString ();	
	}
}
