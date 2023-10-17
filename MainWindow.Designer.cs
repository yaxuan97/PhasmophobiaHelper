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
			GhostSpeedGroup = new GroupBox();
			GhostSpeedRadioButtons = new RadioButton[] { new RadioButton(), new RadioButton(), new RadioButton(), new RadioButton(), new RadioButton() };
			KeyBindingGroup = new GroupBox();
			RecordGhostStepKey = new TextBox();
			RecordGhostStep = new Label();
			KeyBindingGroup.SuspendLayout();
			SuspendLayout();
			// 
			// GhostSpeedGroup
			// 
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[0]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[1]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[2]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[3]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[4]);
			GhostSpeedGroup.Location = new Point(30, 10);
			GhostSpeedGroup.Name = "GhostSpeedGroup";
			GhostSpeedGroup.Size = new Size(600, 60);
			GhostSpeedGroup.TabIndex = 0;
			GhostSpeedGroup.TabStop = false;
			GhostSpeedGroup.Text = "鬼魂移动速度";
			// 
			// KeyBindingGroup
			//
			KeyBindingGroup.Controls.Add(RecordGhostStepKey);
			KeyBindingGroup.Controls.Add(RecordGhostStep);
			KeyBindingGroup.Location = new Point(30, 120);
			KeyBindingGroup.Name = "KeyBindingGroup";
			KeyBindingGroup.Size = new Size(600, 300);
			KeyBindingGroup.TabIndex = 1;
			KeyBindingGroup.TabStop = false;
			KeyBindingGroup.Text = "快捷键设置";
			// 
			// RecordGhostStepKey
			// 
			RecordGhostStepKey.Location = new Point(90, 28);
			RecordGhostStepKey.Name = "RecordGhostStepKey";
			RecordGhostStepKey.Size = new Size(97, 23);
			RecordGhostStepKey.TabIndex = 1;
			RecordGhostStepKey.TextAlign = HorizontalAlignment.Center;
			RecordGhostStepKey.KeyDown += RecordGhostStepKey_KeyDown;
			// 
			// RecordGhostStep
			// 
			RecordGhostStep.AutoSize = true;
			RecordGhostStep.Location = new Point(6, 28);
			RecordGhostStep.Name = "RecordGhostStep";
			RecordGhostStep.Size = new Size(80, 17);
			RecordGhostStep.TabIndex = 0;
			RecordGhostStep.Text = "记录鬼魂脚步";
			RecordGhostStep.TextAlign = ContentAlignment.MiddleCenter;
			RecordGhostStep.Click += RecordGhostStep_Click;
			// 
			// GhostSpeedRadioButtons[0]
			// 
			GhostSpeedRadioButtons[0].AutoSize = true;
			GhostSpeedRadioButtons[0].Location = new Point(50, 20);
			GhostSpeedRadioButtons[0].Name = "P50";
			GhostSpeedRadioButtons[0].Size = new Size(100, 20);
			GhostSpeedRadioButtons[0].TabIndex = 1;
			GhostSpeedRadioButtons[0].TabStop = true;
			GhostSpeedRadioButtons[0].Text = "50%";
			GhostSpeedRadioButtons[0].UseVisualStyleBackColor = true;
			GhostSpeedRadioButtons[0].CheckedChanged += P50_CheckedChanged;
			// 
			// GhostSpeedRadioButtons[0]
			// 
			GhostSpeedRadioButtons[1].AutoSize = true;
			GhostSpeedRadioButtons[1].Location = new Point(150, 20);
			GhostSpeedRadioButtons[1].Name = "P75";
			GhostSpeedRadioButtons[1].Size = new Size(100, 20);
			GhostSpeedRadioButtons[1].TabIndex = 2;
			GhostSpeedRadioButtons[1].TabStop = true;
			GhostSpeedRadioButtons[1].Text = "75%";
			GhostSpeedRadioButtons[1].UseVisualStyleBackColor = true;
			GhostSpeedRadioButtons[1].CheckedChanged += P75_CheckedChanged;
			// 
			// GhostSpeedRadioButtons[0]
			// 
			GhostSpeedRadioButtons[2].AutoSize = true;
			GhostSpeedRadioButtons[2].Location = new Point(250, 20);
			GhostSpeedRadioButtons[2].Name = "P100";
			GhostSpeedRadioButtons[2].Size = new Size(100, 20);
			GhostSpeedRadioButtons[2].TabIndex = 3;
			GhostSpeedRadioButtons[2].TabStop = true;
			GhostSpeedRadioButtons[2].Text = "100%";
			GhostSpeedRadioButtons[2].UseVisualStyleBackColor = true;
			GhostSpeedRadioButtons[2].CheckedChanged += P100_CheckedChanged;
			// 
			// GhostSpeedRadioButtons[0]
			// 
			GhostSpeedRadioButtons[3].AutoSize = true;
			GhostSpeedRadioButtons[3].Location = new Point(350, 20);
			GhostSpeedRadioButtons[3].Name = "P125";
			GhostSpeedRadioButtons[3].Size = new Size(100, 20);
			GhostSpeedRadioButtons[3].TabIndex = 4;
			GhostSpeedRadioButtons[3].TabStop = true;
			GhostSpeedRadioButtons[3].Text = "125%";
			GhostSpeedRadioButtons[3].UseVisualStyleBackColor = true;
			GhostSpeedRadioButtons[3].CheckedChanged += P125_CheckedChanged;
			// 
			// GhostSpeedRadioButtons[0]
			// 
			GhostSpeedRadioButtons[4].AutoSize = true;
			GhostSpeedRadioButtons[4].Location = new Point(450, 20);
			GhostSpeedRadioButtons[4].Name = "P150";
			GhostSpeedRadioButtons[4].Size = new Size(100, 20);
			GhostSpeedRadioButtons[4].TabIndex = 5;
			GhostSpeedRadioButtons[4].TabStop = true;
			GhostSpeedRadioButtons[4].Text = "150%";
			GhostSpeedRadioButtons[4].UseVisualStyleBackColor = true;
			GhostSpeedRadioButtons[4].CheckedChanged += P150_CheckedChanged;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(664, 461);
			Controls.Add(KeyBindingGroup);
			Controls.Add(GhostSpeedGroup);
			Name = "MainWindow";
			Text = "恐鬼症记录器";
			KeyBindingGroup.ResumeLayout(false);
			KeyBindingGroup.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox GhostSpeedGroup;
		private GroupBox KeyBindingGroup;
		private TextBox RecordGhostStepKey;
		private Label RecordGhostStep;
		private RadioButton[] GhostSpeedRadioButtons;
	}
}