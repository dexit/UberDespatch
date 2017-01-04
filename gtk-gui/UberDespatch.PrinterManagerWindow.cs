
// This file has been generated by the GUI designer. Do not modify.
namespace UberDespatch
{
	public partial class PrinterManagerWindow
	{
		private global::Gtk.VBox MainLayout;

		private global::Gtk.Frame ManagePrinterProfilesFrame;

		private global::Gtk.Alignment PrinterProfileManagementAlignment;

		private global::Gtk.VBox PrinterProfileManagementLayout;

		private global::Gtk.ComboBox PrinterProfileSelectionCombo;

		private global::Gtk.HBox PrinterProfileControlsLayout;

		private global::Gtk.Button PrinterProfileRemoveButton;

		private global::Gtk.Button PrinterProfileAddButton;

		private global::Gtk.Label PrinterProfileManagementLabel;

		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment PrinterProfileDetailsAlignment;

		private global::Gtk.VBox PrinterProfileDetailsLayout;

		private global::Gtk.HBox PrinterProfileNameLayout;

		private global::Gtk.Label PrinterProfileNameLabel;

		private global::Gtk.Entry PrinterProfileNameEntry;

		private global::Gtk.HBox PrinterProfilePrinterLayout;

		private global::Gtk.Label PrinterProfilePrinterLabel;

		private global::Gtk.ComboBox PrinterProfilePrinterCombo;

		private global::Gtk.Button PrinterProfileSaveButton;

		private global::Gtk.Label PrinterProfileDetailsLabel;

		private global::Gtk.HBox MainControlsLayout;

		private global::Gtk.Button CancelButton;

		private global::Gtk.Button ConfirmButton;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget UberDespatch.PrinterManagerWindow
			this.Name = "UberDespatch.PrinterManagerWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Printer Manager");
			this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-print", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(8));
			this.DefaultWidth = 640;
			this.DefaultHeight = 300;
			// Container child UberDespatch.PrinterManagerWindow.Gtk.Container+ContainerChild
			this.MainLayout = new global::Gtk.VBox();
			this.MainLayout.Name = "MainLayout";
			this.MainLayout.Spacing = 6;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.ManagePrinterProfilesFrame = new global::Gtk.Frame();
			this.ManagePrinterProfilesFrame.Name = "ManagePrinterProfilesFrame";
			this.ManagePrinterProfilesFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child ManagePrinterProfilesFrame.Gtk.Container+ContainerChild
			this.PrinterProfileManagementAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.PrinterProfileManagementAlignment.Name = "PrinterProfileManagementAlignment";
			this.PrinterProfileManagementAlignment.LeftPadding = ((uint)(12));
			// Container child PrinterProfileManagementAlignment.Gtk.Container+ContainerChild
			this.PrinterProfileManagementLayout = new global::Gtk.VBox();
			this.PrinterProfileManagementLayout.Name = "PrinterProfileManagementLayout";
			this.PrinterProfileManagementLayout.Spacing = 6;
			// Container child PrinterProfileManagementLayout.Gtk.Box+BoxChild
			this.PrinterProfileSelectionCombo = global::Gtk.ComboBox.NewText();
			this.PrinterProfileSelectionCombo.Name = "PrinterProfileSelectionCombo";
			this.PrinterProfileManagementLayout.Add(this.PrinterProfileSelectionCombo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileManagementLayout[this.PrinterProfileSelectionCombo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child PrinterProfileManagementLayout.Gtk.Box+BoxChild
			this.PrinterProfileControlsLayout = new global::Gtk.HBox();
			this.PrinterProfileControlsLayout.Name = "PrinterProfileControlsLayout";
			this.PrinterProfileControlsLayout.Spacing = 6;
			// Container child PrinterProfileControlsLayout.Gtk.Box+BoxChild
			this.PrinterProfileRemoveButton = new global::Gtk.Button();
			this.PrinterProfileRemoveButton.WidthRequest = 150;
			this.PrinterProfileRemoveButton.HeightRequest = 40;
			this.PrinterProfileRemoveButton.CanFocus = true;
			this.PrinterProfileRemoveButton.Name = "PrinterProfileRemoveButton";
			this.PrinterProfileRemoveButton.UseUnderline = true;
			this.PrinterProfileRemoveButton.Label = global::Mono.Unix.Catalog.GetString("Remove Profile");
			this.PrinterProfileControlsLayout.Add(this.PrinterProfileRemoveButton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileControlsLayout[this.PrinterProfileRemoveButton]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child PrinterProfileControlsLayout.Gtk.Box+BoxChild
			this.PrinterProfileAddButton = new global::Gtk.Button();
			this.PrinterProfileAddButton.WidthRequest = 150;
			this.PrinterProfileAddButton.HeightRequest = 40;
			this.PrinterProfileAddButton.CanFocus = true;
			this.PrinterProfileAddButton.Name = "PrinterProfileAddButton";
			this.PrinterProfileAddButton.UseUnderline = true;
			this.PrinterProfileAddButton.Label = global::Mono.Unix.Catalog.GetString("Add Profile");
			this.PrinterProfileControlsLayout.Add(this.PrinterProfileAddButton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileControlsLayout[this.PrinterProfileAddButton]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.PrinterProfileManagementLayout.Add(this.PrinterProfileControlsLayout);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileManagementLayout[this.PrinterProfileControlsLayout]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.PrinterProfileManagementAlignment.Add(this.PrinterProfileManagementLayout);
			this.ManagePrinterProfilesFrame.Add(this.PrinterProfileManagementAlignment);
			this.PrinterProfileManagementLabel = new global::Gtk.Label();
			this.PrinterProfileManagementLabel.Name = "PrinterProfileManagementLabel";
			this.PrinterProfileManagementLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Manage Printer Profiles</b>");
			this.PrinterProfileManagementLabel.UseMarkup = true;
			this.ManagePrinterProfilesFrame.LabelWidget = this.PrinterProfileManagementLabel;
			this.MainLayout.Add(this.ManagePrinterProfilesFrame);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.MainLayout[this.ManagePrinterProfilesFrame]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.PrinterProfileDetailsAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.PrinterProfileDetailsAlignment.Name = "PrinterProfileDetailsAlignment";
			this.PrinterProfileDetailsAlignment.LeftPadding = ((uint)(12));
			// Container child PrinterProfileDetailsAlignment.Gtk.Container+ContainerChild
			this.PrinterProfileDetailsLayout = new global::Gtk.VBox();
			this.PrinterProfileDetailsLayout.Name = "PrinterProfileDetailsLayout";
			this.PrinterProfileDetailsLayout.Spacing = 6;
			// Container child PrinterProfileDetailsLayout.Gtk.Box+BoxChild
			this.PrinterProfileNameLayout = new global::Gtk.HBox();
			this.PrinterProfileNameLayout.Name = "PrinterProfileNameLayout";
			this.PrinterProfileNameLayout.Spacing = 6;
			// Container child PrinterProfileNameLayout.Gtk.Box+BoxChild
			this.PrinterProfileNameLabel = new global::Gtk.Label();
			this.PrinterProfileNameLabel.WidthRequest = 200;
			this.PrinterProfileNameLabel.Name = "PrinterProfileNameLabel";
			this.PrinterProfileNameLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Name");
			this.PrinterProfileNameLabel.Wrap = true;
			this.PrinterProfileNameLabel.SingleLineMode = true;
			this.PrinterProfileNameLayout.Add(this.PrinterProfileNameLabel);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileNameLayout[this.PrinterProfileNameLabel]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child PrinterProfileNameLayout.Gtk.Box+BoxChild
			this.PrinterProfileNameEntry = new global::Gtk.Entry();
			this.PrinterProfileNameEntry.TooltipMarkup = "The URL leading to the remote rules, these should be provided in JSON format matc" +
				"hing the same layout as the local rules. If no remote rules are avilable the loc" +
				"al rules will be used instead.";
			this.PrinterProfileNameEntry.CanFocus = true;
			this.PrinterProfileNameEntry.Name = "PrinterProfileNameEntry";
			this.PrinterProfileNameEntry.IsEditable = true;
			this.PrinterProfileNameEntry.InvisibleChar = '•';
			this.PrinterProfileNameLayout.Add(this.PrinterProfileNameEntry);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileNameLayout[this.PrinterProfileNameEntry]));
			w9.Position = 1;
			this.PrinterProfileDetailsLayout.Add(this.PrinterProfileNameLayout);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileDetailsLayout[this.PrinterProfileNameLayout]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child PrinterProfileDetailsLayout.Gtk.Box+BoxChild
			this.PrinterProfilePrinterLayout = new global::Gtk.HBox();
			this.PrinterProfilePrinterLayout.Name = "PrinterProfilePrinterLayout";
			this.PrinterProfilePrinterLayout.Spacing = 6;
			// Container child PrinterProfilePrinterLayout.Gtk.Box+BoxChild
			this.PrinterProfilePrinterLabel = new global::Gtk.Label();
			this.PrinterProfilePrinterLabel.WidthRequest = 200;
			this.PrinterProfilePrinterLabel.Name = "PrinterProfilePrinterLabel";
			this.PrinterProfilePrinterLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Printer");
			this.PrinterProfilePrinterLabel.Wrap = true;
			this.PrinterProfilePrinterLabel.SingleLineMode = true;
			this.PrinterProfilePrinterLayout.Add(this.PrinterProfilePrinterLabel);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.PrinterProfilePrinterLayout[this.PrinterProfilePrinterLabel]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child PrinterProfilePrinterLayout.Gtk.Box+BoxChild
			this.PrinterProfilePrinterCombo = global::Gtk.ComboBox.NewText();
			this.PrinterProfilePrinterCombo.Name = "PrinterProfilePrinterCombo";
			this.PrinterProfilePrinterLayout.Add(this.PrinterProfilePrinterCombo);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.PrinterProfilePrinterLayout[this.PrinterProfilePrinterCombo]));
			w12.Position = 1;
			this.PrinterProfileDetailsLayout.Add(this.PrinterProfilePrinterLayout);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileDetailsLayout[this.PrinterProfilePrinterLayout]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child PrinterProfileDetailsLayout.Gtk.Box+BoxChild
			this.PrinterProfileSaveButton = new global::Gtk.Button();
			this.PrinterProfileSaveButton.WidthRequest = 150;
			this.PrinterProfileSaveButton.HeightRequest = 40;
			this.PrinterProfileSaveButton.CanFocus = true;
			this.PrinterProfileSaveButton.Name = "PrinterProfileSaveButton";
			this.PrinterProfileSaveButton.UseUnderline = true;
			this.PrinterProfileSaveButton.Label = global::Mono.Unix.Catalog.GetString("Save Profile");
			this.PrinterProfileDetailsLayout.Add(this.PrinterProfileSaveButton);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.PrinterProfileDetailsLayout[this.PrinterProfileSaveButton]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.PrinterProfileDetailsAlignment.Add(this.PrinterProfileDetailsLayout);
			this.frame1.Add(this.PrinterProfileDetailsAlignment);
			this.PrinterProfileDetailsLabel = new global::Gtk.Label();
			this.PrinterProfileDetailsLabel.Name = "PrinterProfileDetailsLabel";
			this.PrinterProfileDetailsLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Printer Profile Details</b>");
			this.PrinterProfileDetailsLabel.UseMarkup = true;
			this.frame1.LabelWidget = this.PrinterProfileDetailsLabel;
			this.MainLayout.Add(this.frame1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.MainLayout[this.frame1]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.MainControlsLayout = new global::Gtk.HBox();
			this.MainControlsLayout.Name = "MainControlsLayout";
			this.MainControlsLayout.Spacing = 6;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.CancelButton = new global::Gtk.Button();
			this.CancelButton.WidthRequest = 150;
			this.CancelButton.HeightRequest = 40;
			this.CancelButton.CanFocus = true;
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.UseUnderline = true;
			this.CancelButton.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			global::Gtk.Image w18 = new global::Gtk.Image();
			this.CancelButton.Image = w18;
			this.MainControlsLayout.Add(this.CancelButton);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout[this.CancelButton]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.ConfirmButton = new global::Gtk.Button();
			this.ConfirmButton.WidthRequest = 150;
			this.ConfirmButton.HeightRequest = 40;
			this.ConfirmButton.CanFocus = true;
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.UseUnderline = true;
			this.ConfirmButton.Label = global::Mono.Unix.Catalog.GetString("Ok");
			global::Gtk.Image w20 = new global::Gtk.Image();
			this.ConfirmButton.Image = w20;
			this.MainControlsLayout.Add(this.ConfirmButton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout[this.ConfirmButton]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			this.MainLayout.Add(this.MainControlsLayout);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.MainLayout[this.MainControlsLayout]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.MainLayout);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.PrinterProfileSelectionCombo.Changed += new global::System.EventHandler(this.OnProfileComboChanged);
			this.PrinterProfileRemoveButton.Released += new global::System.EventHandler(this.OnPrinterProfileRemoveButtonReleased);
			this.PrinterProfileAddButton.Released += new global::System.EventHandler(this.OnPrinterProfileAddReleased);
			this.PrinterProfileSaveButton.Released += new global::System.EventHandler(this.OnPrinterProfileSaveReleased);
			this.CancelButton.Released += new global::System.EventHandler(this.OnCancelButtonReleased);
			this.ConfirmButton.Released += new global::System.EventHandler(this.OnConfirmButtonReleased);
		}
	}
}
