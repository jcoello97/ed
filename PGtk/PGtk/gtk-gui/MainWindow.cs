
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Entry entryNom;
	
	private global::Gtk.Button buttonApply;
	
	private global::Gtk.Label labelSaludoFinal;

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
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Introduce texto:");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.entryNom = new global::Gtk.Entry ();
		this.entryNom.CanFocus = true;
		this.entryNom.Name = "entryNom";
		this.entryNom.IsEditable = true;
		this.entryNom.InvisibleChar = '●';
		this.hbox1.Add (this.entryNom);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNom]));
		w2.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonApply = new global::Gtk.Button ();
		this.buttonApply.CanFocus = true;
		this.buttonApply.Name = "buttonApply";
		this.buttonApply.UseStock = true;
		this.buttonApply.UseUnderline = true;
		this.buttonApply.Label = "gtk-apply";
		this.hbox1.Add (this.buttonApply);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonApply]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.labelSaludoFinal = new global::Gtk.Label ();
		this.labelSaludoFinal.Name = "labelSaludoFinal";
		this.labelSaludoFinal.LabelProp = global::Mono.Unix.Catalog.GetString ("Hola Mundo");
		this.vbox1.Add (this.labelSaludoFinal);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.labelSaludoFinal]));
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
		this.buttonApply.Clicked += new global::System.EventHandler (this.OnButtonApplyClicked);
	}
}
