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

	protected void OnButton1ClickedSumar (object sender, EventArgs e)
	{

		decimal numero1 = decimal.Parse(entry1.Text);
		decimal numero2 = decimal.Parse (entry2.Text);
		decimal resultado = numero1 + numero2;
		labelResultado.Text = resultado.ToString();
	}

	protected void OnButton2ClickedRestar (object sender, EventArgs e)
	{
		decimal numero1 = decimal.Parse(entry1.Text);
		decimal numero2 = decimal.Parse (entry2.Text);
		decimal resultado=numero1 - numero2;
		labelResultado.Text = resultado.ToString();
	}

	protected void OnButton3ClickedDividir (object sender, EventArgs e)
	{
		decimal numero1 = decimal.Parse(entry1.Text);
		decimal numero2 = decimal.Parse (entry2.Text);
		decimal resultado=numero1 / numero2;
		labelResultado.Text = resultado.ToString();
	}

	protected void OnButton4ClickedMultiplicar (object sender, EventArgs e)
	{
		decimal numero1 = decimal.Parse(entry1.Text);
		decimal numero2 = decimal.Parse (entry2.Text);
		decimal resultado=numero1 * numero2;
		labelResultado.Text = resultado.ToString();
	}
}
