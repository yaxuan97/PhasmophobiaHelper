namespace PhasmophobiaHelper {
	partial class MainWindow {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			CalcGhostSpeedGroup = new GroupBox();
			TopMostButton = new Button();
			SettingButton = new Button();
			GhostGuessingResultLabel = new Label();
			SpeedResultLabel = new Label();
			NormalSpeedLabel = new Label();
			SpeedLabel = new Label();
			TimerGroup = new GroupBox();
			TimerTextLabel = new Label();
			TimerProgress = new NoDelayprogress();
			GhostIncenseColdDownLabel = new Label();
			SpiritIncenseColdDownLabel = new Label();
			DemonIncenseColdDownLabel = new Label();
			GhostHuntingColdDownLabel = new Label();
			DemonHuntingColdDownLabel = new Label();
			GhostTimer = new System.Windows.Forms.Timer(components);
			CalcGhostSpeedGroup.SuspendLayout();
			TimerGroup.SuspendLayout();
			SuspendLayout();
			// 
			// CalcGhostSpeedGroup
			// 
			CalcGhostSpeedGroup.Controls.Add(TopMostButton);
			CalcGhostSpeedGroup.Controls.Add(SettingButton);
			CalcGhostSpeedGroup.Controls.Add(GhostGuessingResultLabel);
			CalcGhostSpeedGroup.Controls.Add(SpeedResultLabel);
			CalcGhostSpeedGroup.Controls.Add(NormalSpeedLabel);
			CalcGhostSpeedGroup.Controls.Add(SpeedLabel);
			resources.ApplyResources(CalcGhostSpeedGroup, "CalcGhostSpeedGroup");
			CalcGhostSpeedGroup.Name = "CalcGhostSpeedGroup";
			CalcGhostSpeedGroup.TabStop = false;
			// 
			// TopMostButton
			// 
			resources.ApplyResources(TopMostButton, "TopMostButton");
			TopMostButton.Name = "TopMostButton";
			TopMostButton.UseVisualStyleBackColor = true;
			TopMostButton.Click += TopMostButton_Click;
			// 
			// SettingButton
			// 
			resources.ApplyResources(SettingButton, "SettingButton");
			SettingButton.Name = "SettingButton";
			SettingButton.UseVisualStyleBackColor = true;
			SettingButton.Click += SettingButton_Click;
			// 
			// GhostGuessingResultLabel
			// 
			resources.ApplyResources(GhostGuessingResultLabel, "GhostGuessingResultLabel");
			GhostGuessingResultLabel.Name = "GhostGuessingResultLabel";
			// 
			// SpeedResultLabel
			// 
			resources.ApplyResources(SpeedResultLabel, "SpeedResultLabel");
			SpeedResultLabel.Name = "SpeedResultLabel";
			// 
			// NormalSpeedLabel
			// 
			resources.ApplyResources(NormalSpeedLabel, "NormalSpeedLabel");
			NormalSpeedLabel.Name = "NormalSpeedLabel";
			// 
			// SpeedLabel
			// 
			resources.ApplyResources(SpeedLabel, "SpeedLabel");
			SpeedLabel.Name = "SpeedLabel";
			// 
			// TimerGroup
			// 
			TimerGroup.Controls.Add(TimerTextLabel);
			TimerGroup.Controls.Add(TimerProgress);
			TimerGroup.Controls.Add(GhostIncenseColdDownLabel);
			TimerGroup.Controls.Add(SpiritIncenseColdDownLabel);
			TimerGroup.Controls.Add(DemonIncenseColdDownLabel);
			TimerGroup.Controls.Add(GhostHuntingColdDownLabel);
			TimerGroup.Controls.Add(DemonHuntingColdDownLabel);
			resources.ApplyResources(TimerGroup, "TimerGroup");
			TimerGroup.Name = "TimerGroup";
			TimerGroup.TabStop = false;
			TimerGroup.Paint += TimerGroup_Paint;
			// 
			// TimerTextLabel
			// 
			resources.ApplyResources(TimerTextLabel, "TimerTextLabel");
			TimerTextLabel.BackColor = Color.Transparent;
			TimerTextLabel.Name = "TimerTextLabel";
			// 
			// TimerProgress
			// 
			TimerProgress.BackColor = SystemColors.HotTrack;
			TimerProgress.ForeColor = Color.Gold;
			resources.ApplyResources(TimerProgress, "TimerProgress");
			TimerProgress.MaxValue = 180;
			TimerProgress.MinValue = 0;
			TimerProgress.Name = "TimerProgress";
			TimerProgress.Step = 1;
			TimerProgress.Value = 0;
			// 
			// GhostIncenseColdDownLabel
			// 
			resources.ApplyResources(GhostIncenseColdDownLabel, "GhostIncenseColdDownLabel");
			GhostIncenseColdDownLabel.ForeColor = Color.ForestGreen;
			GhostIncenseColdDownLabel.Name = "GhostIncenseColdDownLabel";
			// 
			// SpiritIncenseColdDownLabel
			// 
			resources.ApplyResources(SpiritIncenseColdDownLabel, "SpiritIncenseColdDownLabel");
			SpiritIncenseColdDownLabel.ForeColor = Color.ForestGreen;
			SpiritIncenseColdDownLabel.Name = "SpiritIncenseColdDownLabel";
			// 
			// DemonIncenseColdDownLabel
			// 
			resources.ApplyResources(DemonIncenseColdDownLabel, "DemonIncenseColdDownLabel");
			DemonIncenseColdDownLabel.ForeColor = Color.ForestGreen;
			DemonIncenseColdDownLabel.Name = "DemonIncenseColdDownLabel";
			// 
			// GhostHuntingColdDownLabel
			// 
			resources.ApplyResources(GhostHuntingColdDownLabel, "GhostHuntingColdDownLabel");
			GhostHuntingColdDownLabel.ForeColor = Color.ForestGreen;
			GhostHuntingColdDownLabel.Name = "GhostHuntingColdDownLabel";
			// 
			// DemonHuntingColdDownLabel
			// 
			resources.ApplyResources(DemonHuntingColdDownLabel, "DemonHuntingColdDownLabel");
			DemonHuntingColdDownLabel.ForeColor = Color.ForestGreen;
			DemonHuntingColdDownLabel.Name = "DemonHuntingColdDownLabel";
			// 
			// GhostTimer
			// 
			GhostTimer.Interval = 1000;
			GhostTimer.Tick += GhostTimer_Tick;
			// 
			// MainWindow
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(TimerGroup);
			Controls.Add(CalcGhostSpeedGroup);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "MainWindow";
			Opacity = 0.95D;
			FormClosed += MainWindow_FormClosed;
			CalcGhostSpeedGroup.ResumeLayout(false);
			CalcGhostSpeedGroup.PerformLayout();
			TimerGroup.ResumeLayout(false);
			TimerGroup.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox CalcGhostSpeedGroup;
		private Label NormalSpeedLabel;
		private Label SpeedLabel;
		private Label GhostGuessingResultLabel;
		private Label SpeedResultLabel;
		private GroupBox TimerGroup;
		private System.Windows.Forms.Timer GhostTimer;
		private Button SettingButton;
		private Button TopMostButton;
		private Label DemonHuntingColdDownLabel;
		private Label GhostHuntingColdDownLabel;
		private Label DemonIncenseColdDownLabel;
		private Label GhostIncenseColdDownLabel;
		private Label SpiritIncenseColdDownLabel;
		private NoDelayprogress TimerProgress;
		private Label TimerTextLabel;
	}
}