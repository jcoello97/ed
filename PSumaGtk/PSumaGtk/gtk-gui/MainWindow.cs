
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Entry entryNum1;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Entry entryNum2;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.Button buttonSuma;
	
	private global::Gtk.Label labelResult;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 1:");
		this.hbox2.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.entryNum1 = new global::Gtk.Entry ();
		this.entryNum1.CanFocus = true;
		this.entryNum1.Name = "entryNum1";
		this.entryNum1.IsEditable = true;
		this.entryNum1.InvisibleChar = '●';
		this.hbox2.Add (this.entryNum1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryNum1]));
		w2.Position = 1;
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 2:");
		this.hbox3.Add (this.label2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label2]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entryNum2 = new global::Gtk.Entry ();
		this.entryNum2.CanFocus = true;
		this.entryNum2.Name = "entryNum2";
		this.entryNum2.IsEditable = true;
		this.entryNum2.InvisibleChar = '●';
		this.hbox3.Add (this.entryNum2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryNum2]));
		w5.Position = 1;
		this.vbox2.Add (this.hbox3);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.buttonSuma = new global::Gtk.Button ();
		this.buttonSuma.CanFocus = true;
		this.buttonSuma.Name = "buttonSuma";
		this.buttonSuma.UseUnderline = true;
		this.buttonSuma.Label = global::Mono.Unix.Catalog.GetString ("+");
		this.hbox7.Add (this.buttonSuma);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.buttonSuma]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		this.hbox4.Add (this.hbox7);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.hbox7]));
		w8.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.labelResult = new global::Gtk.Label ();
		this.labelResult.Name = "labelResult";
		this.hbox4.Add (this.labelResult);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.labelResult]));
		w9.Position = 1;
		w9.Fill = false;
		this.vbox2.Add (this.hbox4);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 270;
		this.DefaultHeight = 151;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonSuma.Clicked += new global::System.EventHandler (this.ButtonClickedSuma);
	}
}
