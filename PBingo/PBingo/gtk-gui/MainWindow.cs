<<<<<<< HEAD

// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Label label1;
	private global::Gtk.Label label2;
	private global::Gtk.Button button1;
	private global::Gtk.Button button2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 0F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero: ");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w1.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.hbox1.Add (this.label2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
		w2.Position = 1;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseStock = true;
		this.button1.UseUnderline = true;
		this.button1.Label = "gtk-go-forward";
		this.hbox1.Add (this.button1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button1]));
		w3.Position = 2;
		w3.Expand = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.vbox1.Add (this.button2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.button2]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
=======

// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.HBox hbox10;
	
	private global::Gtk.Label labelIntro;
	
	private global::Gtk.Label labelNum;
	
	private global::Gtk.Button buttonNum;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.labelIntro = new global::Gtk.Label ();
		this.labelIntro.Name = "labelIntro";
		this.labelIntro.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero: ");
		this.hbox10.Add (this.labelIntro);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelIntro]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.labelNum = new global::Gtk.Label ();
		this.labelNum.Name = "labelNum";
		this.hbox10.Add (this.labelNum);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelNum]));
		w2.Position = 1;
		w2.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.buttonNum = new global::Gtk.Button ();
		this.buttonNum.CanFocus = true;
		this.buttonNum.Name = "buttonNum";
		this.buttonNum.UseStock = true;
		this.buttonNum.UseUnderline = true;
		this.buttonNum.Label = "gtk-go-forward";
		this.hbox10.Add (this.buttonNum);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.buttonNum]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox3.Add (this.hbox10);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox10]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
>>>>>>> a28a14d6b0af41a5511774f9b914dccd45c9e46b