
// This file has been generated by the GUI designer. Do not modify.
namespace UberDespatch
{
	public partial class RulesWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.VBox MainLayout;
		
		private global::Gtk.Frame RulesFrame;
		
		private global::Gtk.Alignment RulesAlignment;
		
		private global::Gtk.VBox RulesLayout;
		
		private global::Gtk.HBox LocalRulesLayout;
		
		private global::Gtk.Label LocalRulesLabel;
		
		private global::Gtk.FileChooserButton LocalRulesFileChooser;
		
		private global::Gtk.HBox RemoteRulesLayout;
		
		private global::Gtk.Label RemoteRulesLabel;
		
		private global::Gtk.Entry RemoteRulesEntry;
		
		private global::Gtk.Label RulesLabel;
		
		private global::Gtk.Frame ZonesFrame;
		
		private global::Gtk.Alignment ZonesAlignment;
		
		private global::Gtk.VBox ZonesLayout;
		
		private global::Gtk.HBox LocalZonesLayout;
		
		private global::Gtk.Label LocalZonesLabel;
		
		private global::Gtk.FileChooserButton LocalZonesFileChooser;
		
		private global::Gtk.HBox RemoteZonesLayout;
		
		private global::Gtk.Label RemoteZonesLabel;
		
		private global::Gtk.Entry RemoteZonesEntry;
		
		private global::Gtk.Label ZonesLabel;
		
		private global::Gtk.Frame LabelsFrame;
		
		private global::Gtk.Alignment LabelsAlignment;
		
		private global::Gtk.VBox LabelsLayout;
		
		private global::Gtk.HBox LocalLabelsLayout;
		
		private global::Gtk.Label LocalLablesLabel;
		
		private global::Gtk.FileChooserButton LocalLabelsFileChooser;
		
		private global::Gtk.HBox RemoteLabelsLayout;
		
		private global::Gtk.Label RemoteLabelsLabel;
		
		private global::Gtk.Entry RemoteLabelsEntry;
		
		private global::Gtk.HBox LocalLabelsTemplateLayout;
		
		private global::Gtk.Label LocalLabelsTemplateLabel;
		
		private global::Gtk.FileChooserButton LocalLabelsTemplateFileChooser;
		
		private global::Gtk.Label LabelsLabel;
		
		private global::Gtk.Frame AlertsFrame;
		
		private global::Gtk.Alignment AlertsAlignment;
		
		private global::Gtk.VBox AlertsLayout;
		
		private global::Gtk.HBox LocalAlertsLayout;
		
		private global::Gtk.Label LocalAlertsLabel;
		
		private global::Gtk.FileChooserButton LocalAlertsFileChooser;
		
		private global::Gtk.HBox RemoteAlertsLayout;
		
		private global::Gtk.Label RemoteAlertsLabel;
		
		private global::Gtk.Entry RemoteAlertsEntry;
		
		private global::Gtk.Label AlertsLabel;
		
		private global::Gtk.HBox MainControlsLayout;
		
		private global::Gtk.Alignment MainControlsSpacerAlignment;
		
		private global::Gtk.Button CancelButton;
		
		private global::Gtk.Button ConfirmButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget UberDespatch.RulesWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "UberDespatch.RulesWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Rules");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(8));
			this.DefaultWidth = 640;
			this.DefaultHeight = 300;
			// Container child UberDespatch.RulesWindow.Gtk.Container+ContainerChild
			this.MainLayout = new global::Gtk.VBox ();
			this.MainLayout.Name = "MainLayout";
			this.MainLayout.Spacing = 6;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.RulesFrame = new global::Gtk.Frame ();
			this.RulesFrame.Name = "RulesFrame";
			this.RulesFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child RulesFrame.Gtk.Container+ContainerChild
			this.RulesAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.RulesAlignment.Name = "RulesAlignment";
			this.RulesAlignment.LeftPadding = ((uint)(12));
			// Container child RulesAlignment.Gtk.Container+ContainerChild
			this.RulesLayout = new global::Gtk.VBox ();
			this.RulesLayout.Name = "RulesLayout";
			this.RulesLayout.Spacing = 6;
			// Container child RulesLayout.Gtk.Box+BoxChild
			this.LocalRulesLayout = new global::Gtk.HBox ();
			this.LocalRulesLayout.Name = "LocalRulesLayout";
			this.LocalRulesLayout.Spacing = 6;
			// Container child LocalRulesLayout.Gtk.Box+BoxChild
			this.LocalRulesLabel = new global::Gtk.Label ();
			this.LocalRulesLabel.WidthRequest = 200;
			this.LocalRulesLabel.Name = "LocalRulesLabel";
			this.LocalRulesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Local File");
			this.LocalRulesLabel.Wrap = true;
			this.LocalRulesLabel.SingleLineMode = true;
			this.LocalRulesLayout.Add (this.LocalRulesLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.LocalRulesLayout [this.LocalRulesLabel]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child LocalRulesLayout.Gtk.Box+BoxChild
			this.LocalRulesFileChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select Rules File"), ((global::Gtk.FileChooserAction)(0)));
			this.LocalRulesFileChooser.TooltipMarkup = "The location where the local rules are to be loaded and saved. These rules are ig" +
			"nored if remote rules are available.";
			this.LocalRulesFileChooser.Name = "LocalRulesFileChooser";
			this.LocalRulesFileChooser.LocalOnly = false;
			this.LocalRulesLayout.Add (this.LocalRulesFileChooser);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.LocalRulesLayout [this.LocalRulesFileChooser]));
			w3.Position = 1;
			this.RulesLayout.Add (this.LocalRulesLayout);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.RulesLayout [this.LocalRulesLayout]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child RulesLayout.Gtk.Box+BoxChild
			this.RemoteRulesLayout = new global::Gtk.HBox ();
			this.RemoteRulesLayout.Name = "RemoteRulesLayout";
			this.RemoteRulesLayout.Spacing = 6;
			// Container child RemoteRulesLayout.Gtk.Box+BoxChild
			this.RemoteRulesLabel = new global::Gtk.Label ();
			this.RemoteRulesLabel.WidthRequest = 200;
			this.RemoteRulesLabel.Name = "RemoteRulesLabel";
			this.RemoteRulesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Remote URL");
			this.RemoteRulesLabel.Wrap = true;
			this.RemoteRulesLabel.SingleLineMode = true;
			this.RemoteRulesLayout.Add (this.RemoteRulesLabel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.RemoteRulesLayout [this.RemoteRulesLabel]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child RemoteRulesLayout.Gtk.Box+BoxChild
			this.RemoteRulesEntry = new global::Gtk.Entry ();
			this.RemoteRulesEntry.TooltipMarkup = "The URL leading to the remote rules, these should be provided in JSON format matc" +
			"hing the same layout as the local rules. If no remote rules are avilable the loc" +
			"al rules will be used instead.";
			this.RemoteRulesEntry.CanFocus = true;
			this.RemoteRulesEntry.Name = "RemoteRulesEntry";
			this.RemoteRulesEntry.IsEditable = true;
			this.RemoteRulesEntry.InvisibleChar = '•';
			this.RemoteRulesLayout.Add (this.RemoteRulesEntry);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.RemoteRulesLayout [this.RemoteRulesEntry]));
			w6.Position = 1;
			this.RulesLayout.Add (this.RemoteRulesLayout);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.RulesLayout [this.RemoteRulesLayout]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.RulesAlignment.Add (this.RulesLayout);
			this.RulesFrame.Add (this.RulesAlignment);
			this.RulesLabel = new global::Gtk.Label ();
			this.RulesLabel.Name = "RulesLabel";
			this.RulesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Rules</b>");
			this.RulesLabel.UseMarkup = true;
			this.RulesFrame.LabelWidget = this.RulesLabel;
			this.MainLayout.Add (this.RulesFrame);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.MainLayout [this.RulesFrame]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.ZonesFrame = new global::Gtk.Frame ();
			this.ZonesFrame.Name = "ZonesFrame";
			this.ZonesFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child ZonesFrame.Gtk.Container+ContainerChild
			this.ZonesAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.ZonesAlignment.Name = "ZonesAlignment";
			this.ZonesAlignment.LeftPadding = ((uint)(12));
			// Container child ZonesAlignment.Gtk.Container+ContainerChild
			this.ZonesLayout = new global::Gtk.VBox ();
			this.ZonesLayout.Name = "ZonesLayout";
			this.ZonesLayout.Spacing = 6;
			// Container child ZonesLayout.Gtk.Box+BoxChild
			this.LocalZonesLayout = new global::Gtk.HBox ();
			this.LocalZonesLayout.Name = "LocalZonesLayout";
			this.LocalZonesLayout.Spacing = 6;
			// Container child LocalZonesLayout.Gtk.Box+BoxChild
			this.LocalZonesLabel = new global::Gtk.Label ();
			this.LocalZonesLabel.WidthRequest = 200;
			this.LocalZonesLabel.Name = "LocalZonesLabel";
			this.LocalZonesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Local File");
			this.LocalZonesLabel.Wrap = true;
			this.LocalZonesLabel.SingleLineMode = true;
			this.LocalZonesLayout.Add (this.LocalZonesLabel);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.LocalZonesLayout [this.LocalZonesLabel]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child LocalZonesLayout.Gtk.Box+BoxChild
			this.LocalZonesFileChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select Zones File"), ((global::Gtk.FileChooserAction)(0)));
			this.LocalZonesFileChooser.TooltipMarkup = "The location where the local zones are to be loaded and saved. These zones are ig" +
			"nored if remote zones are available.";
			this.LocalZonesFileChooser.Name = "LocalZonesFileChooser";
			this.LocalZonesFileChooser.LocalOnly = false;
			this.LocalZonesLayout.Add (this.LocalZonesFileChooser);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.LocalZonesLayout [this.LocalZonesFileChooser]));
			w12.Position = 1;
			this.ZonesLayout.Add (this.LocalZonesLayout);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.ZonesLayout [this.LocalZonesLayout]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child ZonesLayout.Gtk.Box+BoxChild
			this.RemoteZonesLayout = new global::Gtk.HBox ();
			this.RemoteZonesLayout.Name = "RemoteZonesLayout";
			this.RemoteZonesLayout.Spacing = 6;
			// Container child RemoteZonesLayout.Gtk.Box+BoxChild
			this.RemoteZonesLabel = new global::Gtk.Label ();
			this.RemoteZonesLabel.WidthRequest = 200;
			this.RemoteZonesLabel.Name = "RemoteZonesLabel";
			this.RemoteZonesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Remote URL");
			this.RemoteZonesLabel.Wrap = true;
			this.RemoteZonesLabel.SingleLineMode = true;
			this.RemoteZonesLayout.Add (this.RemoteZonesLabel);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.RemoteZonesLayout [this.RemoteZonesLabel]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child RemoteZonesLayout.Gtk.Box+BoxChild
			this.RemoteZonesEntry = new global::Gtk.Entry ();
			this.RemoteZonesEntry.TooltipMarkup = "The URL leading to the remote zones, these should be provided in JSON format matc" +
			"hing the same layout as the local zones. If no remote zones are avilable the loc" +
			"al zones will be used instead.";
			this.RemoteZonesEntry.CanFocus = true;
			this.RemoteZonesEntry.Name = "RemoteZonesEntry";
			this.RemoteZonesEntry.IsEditable = true;
			this.RemoteZonesEntry.InvisibleChar = '•';
			this.RemoteZonesLayout.Add (this.RemoteZonesEntry);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.RemoteZonesLayout [this.RemoteZonesEntry]));
			w15.Position = 1;
			this.ZonesLayout.Add (this.RemoteZonesLayout);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.ZonesLayout [this.RemoteZonesLayout]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.ZonesAlignment.Add (this.ZonesLayout);
			this.ZonesFrame.Add (this.ZonesAlignment);
			this.ZonesLabel = new global::Gtk.Label ();
			this.ZonesLabel.Name = "ZonesLabel";
			this.ZonesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Zones</b>");
			this.ZonesLabel.UseMarkup = true;
			this.ZonesFrame.LabelWidget = this.ZonesLabel;
			this.MainLayout.Add (this.ZonesFrame);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.MainLayout [this.ZonesFrame]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.LabelsFrame = new global::Gtk.Frame ();
			this.LabelsFrame.Name = "LabelsFrame";
			this.LabelsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child LabelsFrame.Gtk.Container+ContainerChild
			this.LabelsAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.LabelsAlignment.Name = "LabelsAlignment";
			this.LabelsAlignment.LeftPadding = ((uint)(12));
			// Container child LabelsAlignment.Gtk.Container+ContainerChild
			this.LabelsLayout = new global::Gtk.VBox ();
			this.LabelsLayout.Name = "LabelsLayout";
			this.LabelsLayout.Spacing = 6;
			// Container child LabelsLayout.Gtk.Box+BoxChild
			this.LocalLabelsLayout = new global::Gtk.HBox ();
			this.LocalLabelsLayout.Name = "LocalLabelsLayout";
			this.LocalLabelsLayout.Spacing = 6;
			// Container child LocalLabelsLayout.Gtk.Box+BoxChild
			this.LocalLablesLabel = new global::Gtk.Label ();
			this.LocalLablesLabel.WidthRequest = 200;
			this.LocalLablesLabel.Name = "LocalLablesLabel";
			this.LocalLablesLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Local File");
			this.LocalLablesLabel.Wrap = true;
			this.LocalLablesLabel.SingleLineMode = true;
			this.LocalLabelsLayout.Add (this.LocalLablesLabel);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.LocalLabelsLayout [this.LocalLablesLabel]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child LocalLabelsLayout.Gtk.Box+BoxChild
			this.LocalLabelsFileChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select Labels File"), ((global::Gtk.FileChooserAction)(0)));
			this.LocalLabelsFileChooser.TooltipMarkup = "The location where the local labels json is to be loaded and saved. These labels " +
			"are ignored if remote labels are available.";
			this.LocalLabelsFileChooser.Name = "LocalLabelsFileChooser";
			this.LocalLabelsFileChooser.LocalOnly = false;
			this.LocalLabelsLayout.Add (this.LocalLabelsFileChooser);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.LocalLabelsLayout [this.LocalLabelsFileChooser]));
			w21.Position = 1;
			this.LabelsLayout.Add (this.LocalLabelsLayout);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.LabelsLayout [this.LocalLabelsLayout]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child LabelsLayout.Gtk.Box+BoxChild
			this.RemoteLabelsLayout = new global::Gtk.HBox ();
			this.RemoteLabelsLayout.Name = "RemoteLabelsLayout";
			this.RemoteLabelsLayout.Spacing = 6;
			// Container child RemoteLabelsLayout.Gtk.Box+BoxChild
			this.RemoteLabelsLabel = new global::Gtk.Label ();
			this.RemoteLabelsLabel.WidthRequest = 200;
			this.RemoteLabelsLabel.Name = "RemoteLabelsLabel";
			this.RemoteLabelsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Remote URL");
			this.RemoteLabelsLabel.Wrap = true;
			this.RemoteLabelsLabel.SingleLineMode = true;
			this.RemoteLabelsLayout.Add (this.RemoteLabelsLabel);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.RemoteLabelsLayout [this.RemoteLabelsLabel]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child RemoteLabelsLayout.Gtk.Box+BoxChild
			this.RemoteLabelsEntry = new global::Gtk.Entry ();
			this.RemoteLabelsEntry.TooltipMarkup = "The URL leading to the remote labels, these should be provided in JSON format mat" +
			"ching the same layout as the local labels. If no remote labels are avilable the " +
			"local labels will be used instead.";
			this.RemoteLabelsEntry.CanFocus = true;
			this.RemoteLabelsEntry.Name = "RemoteLabelsEntry";
			this.RemoteLabelsEntry.IsEditable = true;
			this.RemoteLabelsEntry.InvisibleChar = '•';
			this.RemoteLabelsLayout.Add (this.RemoteLabelsEntry);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.RemoteLabelsLayout [this.RemoteLabelsEntry]));
			w24.Position = 1;
			this.LabelsLayout.Add (this.RemoteLabelsLayout);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.LabelsLayout [this.RemoteLabelsLayout]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child LabelsLayout.Gtk.Box+BoxChild
			this.LocalLabelsTemplateLayout = new global::Gtk.HBox ();
			this.LocalLabelsTemplateLayout.Name = "LocalLabelsTemplateLayout";
			this.LocalLabelsTemplateLayout.Spacing = 6;
			// Container child LocalLabelsTemplateLayout.Gtk.Box+BoxChild
			this.LocalLabelsTemplateLabel = new global::Gtk.Label ();
			this.LocalLabelsTemplateLabel.WidthRequest = 200;
			this.LocalLabelsTemplateLabel.Name = "LocalLabelsTemplateLabel";
			this.LocalLabelsTemplateLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Templates Location");
			this.LocalLabelsTemplateLabel.Wrap = true;
			this.LocalLabelsTemplateLabel.SingleLineMode = true;
			this.LocalLabelsTemplateLayout.Add (this.LocalLabelsTemplateLabel);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.LocalLabelsTemplateLayout [this.LocalLabelsTemplateLabel]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child LocalLabelsTemplateLayout.Gtk.Box+BoxChild
			this.LocalLabelsTemplateFileChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select Label Template Location"), ((global::Gtk.FileChooserAction)(2)));
			this.LocalLabelsTemplateFileChooser.TooltipMarkup = "The location where the local label templates (html) can be found, labels.json wit" +
			"h use a path reletive to this location unless a web url (http/https) is used.";
			this.LocalLabelsTemplateFileChooser.Name = "LocalLabelsTemplateFileChooser";
			this.LocalLabelsTemplateFileChooser.LocalOnly = false;
			this.LocalLabelsTemplateLayout.Add (this.LocalLabelsTemplateFileChooser);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.LocalLabelsTemplateLayout [this.LocalLabelsTemplateFileChooser]));
			w27.Position = 1;
			this.LabelsLayout.Add (this.LocalLabelsTemplateLayout);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.LabelsLayout [this.LocalLabelsTemplateLayout]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.LabelsAlignment.Add (this.LabelsLayout);
			this.LabelsFrame.Add (this.LabelsAlignment);
			this.LabelsLabel = new global::Gtk.Label ();
			this.LabelsLabel.Name = "LabelsLabel";
			this.LabelsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Labels</b>");
			this.LabelsLabel.UseMarkup = true;
			this.LabelsFrame.LabelWidget = this.LabelsLabel;
			this.MainLayout.Add (this.LabelsFrame);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.MainLayout [this.LabelsFrame]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.AlertsFrame = new global::Gtk.Frame ();
			this.AlertsFrame.Name = "AlertsFrame";
			this.AlertsFrame.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child AlertsFrame.Gtk.Container+ContainerChild
			this.AlertsAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.AlertsAlignment.Name = "AlertsAlignment";
			this.AlertsAlignment.LeftPadding = ((uint)(12));
			// Container child AlertsAlignment.Gtk.Container+ContainerChild
			this.AlertsLayout = new global::Gtk.VBox ();
			this.AlertsLayout.Name = "AlertsLayout";
			this.AlertsLayout.Spacing = 6;
			// Container child AlertsLayout.Gtk.Box+BoxChild
			this.LocalAlertsLayout = new global::Gtk.HBox ();
			this.LocalAlertsLayout.Name = "LocalAlertsLayout";
			this.LocalAlertsLayout.Spacing = 6;
			// Container child LocalAlertsLayout.Gtk.Box+BoxChild
			this.LocalAlertsLabel = new global::Gtk.Label ();
			this.LocalAlertsLabel.WidthRequest = 200;
			this.LocalAlertsLabel.Name = "LocalAlertsLabel";
			this.LocalAlertsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Alerts File");
			this.LocalAlertsLabel.Wrap = true;
			this.LocalAlertsLabel.SingleLineMode = true;
			this.LocalAlertsLayout.Add (this.LocalAlertsLabel);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.LocalAlertsLayout [this.LocalAlertsLabel]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child LocalAlertsLayout.Gtk.Box+BoxChild
			this.LocalAlertsFileChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select Labels File"), ((global::Gtk.FileChooserAction)(0)));
			this.LocalAlertsFileChooser.TooltipMarkup = "The location where the local labels json is to be loaded and saved. These labels " +
			"are ignored if remote labels are available.";
			this.LocalAlertsFileChooser.Name = "LocalAlertsFileChooser";
			this.LocalAlertsFileChooser.LocalOnly = false;
			this.LocalAlertsLayout.Add (this.LocalAlertsFileChooser);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.LocalAlertsLayout [this.LocalAlertsFileChooser]));
			w33.Position = 1;
			this.AlertsLayout.Add (this.LocalAlertsLayout);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.AlertsLayout [this.LocalAlertsLayout]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child AlertsLayout.Gtk.Box+BoxChild
			this.RemoteAlertsLayout = new global::Gtk.HBox ();
			this.RemoteAlertsLayout.Name = "RemoteAlertsLayout";
			this.RemoteAlertsLayout.Spacing = 6;
			// Container child RemoteAlertsLayout.Gtk.Box+BoxChild
			this.RemoteAlertsLabel = new global::Gtk.Label ();
			this.RemoteAlertsLabel.WidthRequest = 200;
			this.RemoteAlertsLabel.Name = "RemoteAlertsLabel";
			this.RemoteAlertsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Alerts URL");
			this.RemoteAlertsLabel.Wrap = true;
			this.RemoteAlertsLabel.SingleLineMode = true;
			this.RemoteAlertsLayout.Add (this.RemoteAlertsLabel);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.RemoteAlertsLayout [this.RemoteAlertsLabel]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child RemoteAlertsLayout.Gtk.Box+BoxChild
			this.RemoteAlertsEntry = new global::Gtk.Entry ();
			this.RemoteAlertsEntry.TooltipMarkup = "The URL leading to the remote labels, these should be provided in JSON format mat" +
			"ching the same layout as the local labels. If no remote labels are avilable the " +
			"local labels will be used instead.";
			this.RemoteAlertsEntry.CanFocus = true;
			this.RemoteAlertsEntry.Name = "RemoteAlertsEntry";
			this.RemoteAlertsEntry.IsEditable = true;
			this.RemoteAlertsEntry.InvisibleChar = '•';
			this.RemoteAlertsLayout.Add (this.RemoteAlertsEntry);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.RemoteAlertsLayout [this.RemoteAlertsEntry]));
			w36.Position = 1;
			this.AlertsLayout.Add (this.RemoteAlertsLayout);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.AlertsLayout [this.RemoteAlertsLayout]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			this.AlertsAlignment.Add (this.AlertsLayout);
			this.AlertsFrame.Add (this.AlertsAlignment);
			this.AlertsLabel = new global::Gtk.Label ();
			this.AlertsLabel.Name = "AlertsLabel";
			this.AlertsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Alerts</b>");
			this.AlertsLabel.UseMarkup = true;
			this.AlertsFrame.LabelWidget = this.AlertsLabel;
			this.MainLayout.Add (this.AlertsFrame);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.MainLayout [this.AlertsFrame]));
			w40.Position = 3;
			w40.Expand = false;
			w40.Fill = false;
			// Container child MainLayout.Gtk.Box+BoxChild
			this.MainControlsLayout = new global::Gtk.HBox ();
			this.MainControlsLayout.Name = "MainControlsLayout";
			this.MainControlsLayout.Spacing = 6;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.MainControlsSpacerAlignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.MainControlsSpacerAlignment.Name = "MainControlsSpacerAlignment";
			this.MainControlsLayout.Add (this.MainControlsSpacerAlignment);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout [this.MainControlsSpacerAlignment]));
			w41.Position = 0;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.CancelButton = new global::Gtk.Button ();
			this.CancelButton.WidthRequest = 150;
			this.CancelButton.HeightRequest = 40;
			this.CancelButton.CanFocus = true;
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.UseUnderline = true;
			this.CancelButton.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
			global::Gtk.Image w42 = new global::Gtk.Image ();
			w42.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./Icons/png/no-small.png"));
			this.CancelButton.Image = w42;
			this.MainControlsLayout.Add (this.CancelButton);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout [this.CancelButton]));
			w43.Position = 1;
			w43.Expand = false;
			w43.Fill = false;
			// Container child MainControlsLayout.Gtk.Box+BoxChild
			this.ConfirmButton = new global::Gtk.Button ();
			this.ConfirmButton.WidthRequest = 150;
			this.ConfirmButton.HeightRequest = 40;
			this.ConfirmButton.CanFocus = true;
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.UseUnderline = true;
			this.ConfirmButton.Label = global::Mono.Unix.Catalog.GetString ("Ok");
			global::Gtk.Image w44 = new global::Gtk.Image ();
			w44.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./Icons/png/apply-small.png"));
			this.ConfirmButton.Image = w44;
			this.MainControlsLayout.Add (this.ConfirmButton);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.MainControlsLayout [this.ConfirmButton]));
			w45.Position = 2;
			w45.Expand = false;
			w45.Fill = false;
			this.MainLayout.Add (this.MainControlsLayout);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.MainLayout [this.MainControlsLayout]));
			w46.Position = 4;
			w46.Expand = false;
			w46.Fill = false;
			this.Add (this.MainLayout);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.CancelButton.Released += new global::System.EventHandler (this.OnCancelButtonReleased);
			this.ConfirmButton.Released += new global::System.EventHandler (this.OnConfirmButtonReleased);
		}
	}
}
