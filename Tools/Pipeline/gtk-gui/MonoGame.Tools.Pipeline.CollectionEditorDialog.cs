
// This file has been generated by the GUI designer. Do not modify.
namespace MonoGame.Tools.Pipeline
{
	public partial class CollectionEditorDialog
	{
		private global::Gtk.HPaned hpaned1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.FileChooserWidget filechooserwidget1;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Button button9;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Alignment alignment2;
		
		private global::Gtk.Button button10;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		
		private global::Gtk.TreeView treeview1;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoGame.Tools.Pipeline.CollectionEditorDialog
			this.Name = "MonoGame.Tools.Pipeline.CollectionEditorDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child MonoGame.Tools.Pipeline.CollectionEditorDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 432;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.filechooserwidget1 = new global::Gtk.FileChooserWidget (((global::Gtk.FileChooserAction)(0)));
			this.filechooserwidget1.Name = "filechooserwidget1";
			this.vbox2.Add (this.filechooserwidget1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.filechooserwidget1]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment1]));
			w3.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.button9 = new global::Gtk.Button ();
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseStock = true;
			this.button9.UseUnderline = true;
			this.button9.Label = "gtk-add";
			this.hbox2.Add (this.button9);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button9]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.hpaned1.Add (this.vbox2);
			global::Gtk.Paned.PanedChild w6 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.vbox2]));
			w6.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment2 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.hbox1.Add (this.alignment2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment2]));
			w7.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button10 = new global::Gtk.Button ();
			this.button10.CanFocus = true;
			this.button10.Name = "button10";
			this.button10.UseStock = true;
			this.button10.UseUnderline = true;
			this.button10.Label = "gtk-remove";
			this.hbox1.Add (this.button10);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button10]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.treeview1 = new global::Gtk.TreeView ();
			this.treeview1.CanFocus = true;
			this.treeview1.Name = "treeview1";
			this.treeview1.EnableSearch = false;
			this.treeview1.HeadersVisible = false;
			this.GtkScrolledWindow2.Add (this.treeview1);
			this.vbox3.Add (this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow2]));
			w11.Position = 1;
			this.hpaned1.Add (this.vbox3);
			w1.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(w1 [this.hpaned1]));
			w13.Position = 0;
			// Internal child MonoGame.Tools.Pipeline.CollectionEditorDialog.ActionArea
			global::Gtk.HButtonBox w14 = this.ActionArea;
			w14.Name = "dialog1_ActionArea";
			w14.Spacing = 10;
			w14.BorderWidth = ((uint)(5));
			w14.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14 [this.buttonCancel]));
			w15.Expand = false;
			w15.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w14.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14 [this.buttonOk]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 659;
			this.DefaultHeight = 397;
			this.Show ();
			this.Response += new global::Gtk.ResponseHandler (this.OnResponse);
			this.filechooserwidget1.FileActivated += new global::System.EventHandler (this.AddFileEvent);
			this.button9.Clicked += new global::System.EventHandler (this.AddFileEvent);
			this.button10.Clicked += new global::System.EventHandler (this.RemoveFileEvent);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
