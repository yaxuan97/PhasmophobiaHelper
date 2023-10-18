namespace PhasmophobiaHelper {
	partial class Setting {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
			KeyBindingGroup = new GroupBox();
			TimerKeyTextbox = new AlignableTextBox();
			TimerLabel = new Label();
			ResetGhostStepKeyTextBox = new AlignableTextBox();
			ResetRecordGhostStepLabel = new Label();
			RecordGhostStepKeyTextbox = new AlignableTextBox();
			RecordGhostStepLabel = new Label();
			GhostSpeedGroup = new GroupBox();
			ReturnButton = new Button();
			OpacityGroup = new GroupBox();
			PercentLabel = new Label();
			OpacityTextBox = new TextBox();
			OpacitySlider = new TrackBar();
			KeyBindingGroup.SuspendLayout();
			OpacityGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)OpacitySlider).BeginInit();
			SuspendLayout();
			// 
			// KeyBindingGroup
			// 
			KeyBindingGroup.Controls.Add(TimerKeyTextbox);
			KeyBindingGroup.Controls.Add(TimerLabel);
			KeyBindingGroup.Controls.Add(ResetGhostStepKeyTextBox);
			KeyBindingGroup.Controls.Add(ResetRecordGhostStepLabel);
			KeyBindingGroup.Controls.Add(RecordGhostStepKeyTextbox);
			KeyBindingGroup.Controls.Add(RecordGhostStepLabel);
			resources.ApplyResources(KeyBindingGroup, "KeyBindingGroup");
			KeyBindingGroup.Name = "KeyBindingGroup";
			KeyBindingGroup.TabStop = false;
			// 
			// TimerKeyTextbox
			// 
			resources.ApplyResources(TimerKeyTextbox, "TimerKeyTextbox");
			TimerKeyTextbox.Name = "TimerKeyTextbox";
			TimerKeyTextbox.VerticalAlign = AlignableTextBox.VerticalAlignment.Center;
			TimerKeyTextbox.KeyDown += TimerKeyTextbox_KeyDown;
			TimerKeyTextbox.KeyUp += TimerKeyTextbox_KeyUp;
			// 
			// TimerLabel
			// 
			resources.ApplyResources(TimerLabel, "TimerLabel");
			TimerLabel.Name = "TimerLabel";
			TimerLabel.Click += TimerLabel_Click;
			// 
			// ResetGhostStepKeyTextBox
			// 
			resources.ApplyResources(ResetGhostStepKeyTextBox, "ResetGhostStepKeyTextBox");
			ResetGhostStepKeyTextBox.Name = "ResetGhostStepKeyTextBox";
			ResetGhostStepKeyTextBox.VerticalAlign = AlignableTextBox.VerticalAlignment.Center;
			ResetGhostStepKeyTextBox.KeyDown += ResetGhostStepKey_KeyDown;
			ResetGhostStepKeyTextBox.KeyUp += ResetGhostStepKey_KeyUp;
			// 
			// ResetRecordGhostStepLabel
			// 
			resources.ApplyResources(ResetRecordGhostStepLabel, "ResetRecordGhostStepLabel");
			ResetRecordGhostStepLabel.Name = "ResetRecordGhostStepLabel";
			ResetRecordGhostStepLabel.Click += ResetRecordGhostStepLabel_Click;
			// 
			// RecordGhostStepKeyTextbox
			// 
			resources.ApplyResources(RecordGhostStepKeyTextbox, "RecordGhostStepKeyTextbox");
			RecordGhostStepKeyTextbox.Name = "RecordGhostStepKeyTextbox";
			RecordGhostStepKeyTextbox.VerticalAlign = AlignableTextBox.VerticalAlignment.Center;
			RecordGhostStepKeyTextbox.KeyDown += RecordGhostStepKey_KeyDown;
			RecordGhostStepKeyTextbox.KeyUp += RecordGhostStepKey_KeyUp;
			// 
			// RecordGhostStepLabel
			// 
			resources.ApplyResources(RecordGhostStepLabel, "RecordGhostStepLabel");
			RecordGhostStepLabel.Name = "RecordGhostStepLabel";
			RecordGhostStepLabel.Click += RecordGhostStep_Click;
			// 
			// GhostSpeedGroup
			// 
			resources.ApplyResources(GhostSpeedGroup, "GhostSpeedGroup");
			GhostSpeedGroup.Name = "GhostSpeedGroup";
			GhostSpeedGroup.TabStop = false;
			// 
			// ReturnButton
			// 
			resources.ApplyResources(ReturnButton, "ReturnButton");
			ReturnButton.Name = "ReturnButton";
			ReturnButton.UseVisualStyleBackColor = true;
			ReturnButton.Click += ReturnButton_Click;
			// 
			// OpacityGroup
			// 
			OpacityGroup.Controls.Add(PercentLabel);
			OpacityGroup.Controls.Add(OpacityTextBox);
			OpacityGroup.Controls.Add(OpacitySlider);
			resources.ApplyResources(OpacityGroup, "OpacityGroup");
			OpacityGroup.Name = "OpacityGroup";
			OpacityGroup.TabStop = false;
			// 
			// PercentLabel
			// 
			resources.ApplyResources(PercentLabel, "PercentLabel");
			PercentLabel.Name = "PercentLabel";
			// 
			// OpacityTextBox
			// 
			resources.ApplyResources(OpacityTextBox, "OpacityTextBox");
			OpacityTextBox.Name = "OpacityTextBox";
			OpacityTextBox.TextChanged += OpacityTextBox_TextChanged;
			OpacityTextBox.KeyPress += OpacityTextBox_KeyPress;
			// 
			// OpacitySlider
			// 
			resources.ApplyResources(OpacitySlider, "OpacitySlider");
			OpacitySlider.Maximum = 100;
			OpacitySlider.Minimum = 10;
			OpacitySlider.Name = "OpacitySlider";
			OpacitySlider.Value = 50;
			OpacitySlider.ValueChanged += OpacitySlider_ValueChanged;
			// 
			// Setting
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(OpacityGroup);
			Controls.Add(ReturnButton);
			Controls.Add(KeyBindingGroup);
			Controls.Add(GhostSpeedGroup);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Setting";
			Opacity = 0.95D;
			KeyBindingGroup.ResumeLayout(false);
			KeyBindingGroup.PerformLayout();
			OpacityGroup.ResumeLayout(false);
			OpacityGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)OpacitySlider).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox KeyBindingGroup;
		private AlignableTextBox TimerKeyTextbox;
		private Label TimerLabel;
		private AlignableTextBox ResetGhostStepKeyTextBox;
		private Label ResetRecordGhostStepLabel;
		private AlignableTextBox RecordGhostStepKeyTextbox;
		private Label RecordGhostStepLabel;
		private GroupBox GhostSpeedGroup;
		private Button ReturnButton;
		private GroupBox OpacityGroup;
		private TrackBar OpacitySlider;
		private Label PercentLabel;
		private TextBox OpacityTextBox;
	}
}