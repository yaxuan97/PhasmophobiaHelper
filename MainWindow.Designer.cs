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
			label2 = new Label();
			label1 = new Label();
			SpeedResultLabel = new Label();
			FullSpeedLabel = new Label();
			NormalSpeedLabel = new Label();
			SpeedLabel = new Label();
			TimerGroup = new GroupBox();
			TimerTextLabel = new Label();
			TimerProgress = new ProgressBar();
			GhostTimer = new System.Windows.Forms.Timer(components);
			DemonHuntingColdDownLabel = new Label();
			CalcGhostSpeedGroup.SuspendLayout();
			TimerGroup.SuspendLayout();
			SuspendLayout();
			// 
			// CalcGhostSpeedGroup
			// 
			CalcGhostSpeedGroup.Controls.Add(TopMostButton);
			CalcGhostSpeedGroup.Controls.Add(SettingButton);
			CalcGhostSpeedGroup.Controls.Add(label2);
			CalcGhostSpeedGroup.Controls.Add(label1);
			CalcGhostSpeedGroup.Controls.Add(SpeedResultLabel);
			CalcGhostSpeedGroup.Controls.Add(FullSpeedLabel);
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
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// SpeedResultLabel
			// 
			resources.ApplyResources(SpeedResultLabel, "SpeedResultLabel");
			SpeedResultLabel.Name = "SpeedResultLabel";
			// 
			// FullSpeedLabel
			// 
			resources.ApplyResources(FullSpeedLabel, "FullSpeedLabel");
			FullSpeedLabel.Name = "FullSpeedLabel";
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
			TimerGroup.Controls.Add(DemonHuntingColdDownLabel);
			TimerGroup.Controls.Add(TimerTextLabel);
			TimerGroup.Controls.Add(TimerProgress);
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
			resources.ApplyResources(TimerProgress, "TimerProgress");
			TimerProgress.MarqueeAnimationSpeed = 1000;
			TimerProgress.Maximum = 180;
			TimerProgress.Name = "TimerProgress";
			TimerProgress.Step = 1;
			// 
			// GhostTimer
			// 
			GhostTimer.Interval = 1000;
			GhostTimer.Tick += GhostTimer_Tick;
			// 
			// DemonHuntingColdDownLabel
			// 
			resources.ApplyResources(DemonHuntingColdDownLabel, "DemonHuntingColdDownLabel");
			DemonHuntingColdDownLabel.Name = "DemonHuntingColdDownLabel";
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
		private Label FullSpeedLabel;
		private Label NormalSpeedLabel;
		private Label SpeedLabel;
		private Label label2;
		private Label label1;
		private Label SpeedResultLabel;
		private GroupBox TimerGroup;
		private ProgressBar TimerProgress;
		private Label TimerTextLabel;
		private System.Windows.Forms.Timer GhostTimer;
		private Button SettingButton;
		private Button TopMostButton;
		private Label DemonHuntingColdDownLabel;
	}
}