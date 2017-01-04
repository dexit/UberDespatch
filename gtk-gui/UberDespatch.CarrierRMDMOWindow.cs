
// This file has been generated by the GUI designer. Do not modify.
namespace UberDespatch
{
	public partial class CarrierRMDMOWindow
	{
		private global::Gtk.VBox CarrierLayout;

		private global::Gtk.Frame APIFrame;

		private global::Gtk.Alignment APIAlignment;

		private global::Gtk.VBox APILayout;

		private global::Gtk.Image CarrierImage;

		private global::Gtk.HBox InputLayout;

		private global::Gtk.Label InputLabel;

		private global::Gtk.FileChooserButton InputFileChooser;

		private global::Gtk.Entry InputFilenameEntry;

		private global::Gtk.HBox OutputLayout;

		private global::Gtk.Label OutputLabel;

		private global::Gtk.FileChooserButton OutputFileChooser;

		private global::Gtk.Entry OutputFilenameEntry;

		private global::Gtk.Label CarrierLabel;

		private global::Gtk.Frame TemplateFrame;

		private global::Gtk.Alignment TemplateAlignment;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView TemplateTextView;

		private global::Gtk.Label TemplateLabel;

		private global::Gtk.HBox MainControlsLayout;

		private global::Gtk.Alignment MainControlsSpacerAlignment;

		private global::Gtk.Button CancelButton;

		private global::Gtk.Button ConfirmButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget UberDespatch.CarrierRMDMOWindow
			this.Name = "UberDespatch.CarrierRMDMOWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("RoyalMail Settings");
			this.Icon = new global::Gdk.Pixbuf(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "./Icons/png/plugin.png"));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(8));
			// Container child UberDespatch.CarrierRMDMOWindow.Gtk.Container+ContainerChild
			this.CarrierLayout = new global::Gtk.VBox();
			this.CarrierLayout.Name = "CarrierLayout";
			this.CarrierLayout.Spacing = 6;
			// Container child CarrierLayout.Gtk.Box+BoxChild
			this.APIFrame = new global::Gtk.Frame();
			this.APIFrame.Name = "APIFrame";
			this.APIFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			this.APIFrame.BorderWidth = ((uint)(8));
			// Container child APIFrame.Gtk.Container+ContainerChild
			this.APIAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.APIAlignment.Name = "APIAlignment";
			this.APIAlignment.LeftPadding = ((uint)(12));
			// Container child APIAlignment.Gtk.Container+ContainerChild
			this.APILayout = new global::Gtk.VBox();
			this.APILayout.Name = "APILayout";
			this.APILayout.Spacing = 6;
			// Container child APILayout.Gtk.Box+BoxChild
			this.CarrierImage = new global::Gtk.Image();
			this.CarrierImage.Name = "CarrierImage";
			this.APILayout.Add(this.CarrierImage);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.APILayout[this.CarrierImage]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child APILayout.Gtk.Box+BoxChild
			this.InputLayout = new global::Gtk.HBox();
			this.InputLayout.Name = "InputLayout";
			this.InputLayout.Spacing = 6;
			// Container child InputLayout.Gtk.Box+BoxChild
			this.InputLabel = new global::Gtk.Label();
			this.InputLabel.WidthRequest = 200;
			this.InputLabel.Name = "InputLabel";
			this.InputLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Input");
			this.InputLabel.Wrap = true;
			this.InputLabel.SingleLineMode = true;
			this.InputLayout.Add(this.InputLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.InputLayout[this.InputLabel]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child InputLayout.Gtk.Box+BoxChild
			this.InputFileChooser = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select Downloads Folder"), ((global::Gtk.FileChooserAction)(2)));
			this.InputFileChooser.TooltipMarkup = "The location were RMDMO csv input files are to be saved, this should match the se" +
				"ttings on RMDMO.";
			this.InputFileChooser.Name = "InputFileChooser";
			this.InputLayout.Add(this.InputFileChooser);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.InputLayout[this.InputFileChooser]));
			w3.Position = 1;
			// Container child InputLayout.Gtk.Box+BoxChild
			this.InputFilenameEntry = new global::Gtk.Entry();
			this.InputFilenameEntry.TooltipMarkup = "The filename for the RMDMO input file. This should match the setting on RMDMO. ";
			this.InputFilenameEntry.CanFocus = true;
			this.InputFilenameEntry.Name = "InputFilenameEntry";
			this.InputFilenameEntry.IsEditable = true;
			this.InputFilenameEntry.InvisibleChar = '•';
			this.InputLayout.Add(this.InputFilenameEntry);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.InputLayout[this.InputFilenameEntry]));
			w4.Position = 2;
			this.APILayout.Add(this.InputLayout);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.APILayout[this.InputLayout]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child APILayout.Gtk.Box+BoxChild
			this.OutputLayout = new global::Gtk.HBox();
			this.OutputLayout.Name = "OutputLayout";
			this.OutputLayout.Spacing = 6;
			// Container child OutputLayout.Gtk.Box+BoxChild
			this.OutputLabel = new global::Gtk.Label();
			this.OutputLabel.WidthRequest = 200;
			this.OutputLabel.Name = "OutputLabel";
			this.OutputLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Output");
			this.OutputLabel.Wrap = true;
			this.OutputLabel.SingleLineMode = true;
			this.OutputLayout.Add(this.OutputLabel);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.OutputLayout[this.OutputLabel]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child OutputLayout.Gtk.Box+BoxChild
			this.OutputFileChooser = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select Downloads Folder"), ((global::Gtk.FileChooserAction)(2)));
			this.OutputFileChooser.TooltipMarkup = "The location were RMDMO csv output files are to be saved, this should match the s" +
				"ettings on RMDMO.";
			this.OutputFileChooser.Name = "OutputFileChooser";
			this.OutputLayout.Add(this.OutputFileChooser);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.OutputLayout[this.OutputFileChooser]));
			w7.Position = 1;
			// Container child OutputLayout.Gtk.Box+BoxChild
			this.OutputFilenameEntry = new global::Gtk.Entry();
			this.OutputFilenameEntry.TooltipMarkup = "The filename for the RMDMO output file. This should match the setting on RMDMO. ";
			this.OutputFilenameEntry.CanFocus = true;
			this.OutputFilenameEntry.Name = "OutputFilenameEntry";
			this.OutputFilenameEntry.IsEditable = true;
			this.OutputFilenameEntry.InvisibleChar = '•';
			this.OutputLayout.Add(this.OutputFilenameEntry);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.OutputLayout[this.OutputFilenameEntry]));
			w8.Position = 2;
			this.APILayout.Add(this.OutputLayout);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.APILayout[this.OutputLayout]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.APIAlignment.Add(this.APILayout);
			this.APIFrame.Add(this.APIAlignment);
			this.CarrierLabel = new global::Gtk.Label();
			this.CarrierLabel.Name = "CarrierLabel";
			this.CarrierLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>RoyalMail Settings</b>");
			this.CarrierLabel.UseMarkup = true;
			this.APIFrame.LabelWidget = this.CarrierLabel;
			this.CarrierLayout.Add(this.APIFrame);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.CarrierLayout[this.APIFrame]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child CarrierLayout.Gtk.Box+BoxChild
			this.TemplateFrame = new global::Gtk.Frame();
			this.TemplateFrame.Name = "TemplateFrame";
			this.TemplateFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child TemplateFrame.Gtk.Container+ContainerChild
			this.TemplateAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.TemplateAlignment.Name = "TemplateAlignment";
			this.TemplateAlignment.LeftPadding = ((uint)(12));
			// Container child TemplateAlignment.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.TemplateTextView = new global::Gtk.TextView();
			this.TemplateTextView.TooltipMarkup = "Enter the template used by RMDMO here. {Tags} will be replaced with order data.";
			this.TemplateTextView.CanFocus = true;
			this.TemplateTextView.Name = "TemplateTextView";
			this.TemplateTextView.AcceptsTab = false;
			this.TemplateTextView.LeftMargin = 4;
			this.TemplateTextView.RightMargin = 4;
			this.GtkScrolledWindow.Add(this.TemplateTextView);
			this.TemplateAlignment.Add(this.GtkScrolledWindow);
			this.TemplateFrame.Add(this.TemplateAlignment);
			this.TemplateLabel = new global::Gtk.Label();
			this.TemplateLabel.Name = "TemplateLabel";
			this.TemplateLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Template</b>");
			this.TemplateLabel.UseMarkup = true;
			this.TemplateFrame.LabelWidget = this.TemplateLabel;
			this.CarrierLayout.Add(this.TemplateFrame);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.CarrierLayout[this.TemplateFrame]));
			w16.Position = 1;
			// Container child CarrierLayout.Gtk.Box+BoxChild
			this.MainControlsLayout = new global::Gtk.HBox();
			this.MainControlsLayout.Name = "MainControlsLayout";
			this.MainControlsLayout.Spacing = 6;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.MainControlsSpacerAlignment = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.MainControlsSpacerAlignment.Name = "MainControlsSpacerAlignment";
			this.MainControlsLayout.Add(this.MainControlsSpacerAlignment);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout[this.MainControlsSpacerAlignment]));
			w17.Position = 0;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.CancelButton = new global::Gtk.Button();
			this.CancelButton.WidthRequest = 150;
			this.CancelButton.CanFocus = true;
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.UseUnderline = true;
			this.CancelButton.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			global::Gtk.Image w18 = new global::Gtk.Image();
			w18.Pixbuf = new global::Gdk.Pixbuf(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "./Icons/png/no-small.png"));
			this.CancelButton.Image = w18;
			this.MainControlsLayout.Add(this.CancelButton);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout[this.CancelButton]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.ConfirmButton = new global::Gtk.Button();
			this.ConfirmButton.WidthRequest = 150;
			this.ConfirmButton.CanFocus = true;
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.UseUnderline = true;
			this.ConfirmButton.Label = global::Mono.Unix.Catalog.GetString("Ok");
			global::Gtk.Image w20 = new global::Gtk.Image();
			w20.Pixbuf = new global::Gdk.Pixbuf(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, "./Icons/png/apply-small.png"));
			this.ConfirmButton.Image = w20;
			this.MainControlsLayout.Add(this.ConfirmButton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout[this.ConfirmButton]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			this.CarrierLayout.Add(this.MainControlsLayout);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.CarrierLayout[this.MainControlsLayout]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.CarrierLayout);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 654;
			this.DefaultHeight = 326;
			this.Show();
			this.CancelButton.Released += new global::System.EventHandler(this.OnCancelButtonReleased);
			this.ConfirmButton.Released += new global::System.EventHandler(this.OnConfirmButtonReleased);
		}
	}
}
