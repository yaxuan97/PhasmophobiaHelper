using PhasmophobiaHelper.Properties;
using System.Diagnostics;

namespace PhasmophobiaHelper {
	public partial class Setting : Form {
		public Setting() {
			InitializeComponent();
			FuckVs();
			GhostSpeedRadioButtons[Program.window.GhostSpeed].Checked = true;
			RecordGhostStepKeyTextbox.Text = Util.KeyDataToString(Program.window.RecordGhostStepKeyBinding);
			ResetGhostStepKeyTextBox.Text = Util.KeyDataToString(Program.window.StopRecordGhostStepKeyBinding);
			TimerKeyTextbox.Text += Util.KeyDataToString(Program.window.TimerKeyBinding);
			OpacitySlider.Value = (int)(Program.window.Opacity * 100);
			Opacity = Program.window.Opacity;
			OpacityTextBox.Text = ((int)(Opacity * 100)).ToString();
		}
		private readonly RadioButton[] GhostSpeedRadioButtons = new RadioButton[] { new RadioButton(), new RadioButton(), new RadioButton(), new RadioButton(), new RadioButton() };
		/// <summary>
		///  Fuck VS: Don't Change My Code!!!
		/// </summary>
		private void FuckVs() {
			RecordGhostStepKeyTextbox.AutoSize = false;
			RecordGhostStepKeyTextbox.Height = 32;
			ResetGhostStepKeyTextBox.AutoSize = false;
			ResetGhostStepKeyTextBox.Height = 32;
			TimerKeyTextbox.AutoSize = false;
			TimerKeyTextbox.Height = 32;
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[0]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[1]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[2]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[3]);
			GhostSpeedGroup.Controls.Add(GhostSpeedRadioButtons[4]);
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
		}

		private void RecordGhostStepKey_KeyDown(object sender, KeyEventArgs e) {
			Program.window.RecordGhostStepKeyBinding = e.KeyData;
		}
		private void RecordGhostStepKey_KeyUp(object sender, KeyEventArgs e) {
			RecordGhostStepKeyTextbox.Text = Util.KeyDataToString(Program.window.RecordGhostStepKeyBinding);
			Settings.Default.RecordGhostSpeedKeyBinding = (int)Program.window.RecordGhostStepKeyBinding;
			Settings.Default.Save();
		}
		private void ResetGhostStepKey_KeyDown(object sender, KeyEventArgs e) {
			Program.window.StopRecordGhostStepKeyBinding = e.KeyData;
		}
		private void ResetGhostStepKey_KeyUp(object sender, KeyEventArgs e) {
			ResetGhostStepKeyTextBox.Text = Util.KeyDataToString(Program.window.StopRecordGhostStepKeyBinding);
			Settings.Default.ResetGhostSpeedKeyBinding = (int)Program.window.StopRecordGhostStepKeyBinding;
			Settings.Default.Save();
		}
		private void TimerKeyTextbox_KeyDown(object sender, KeyEventArgs e) {
			Program.window.TimerKeyBinding = e.KeyData;
		}
		private void TimerKeyTextbox_KeyUp(object sender, KeyEventArgs e) {
			Settings.Default.TimerKeyBinding = (int)Program.window.TimerKeyBinding;
			Settings.Default.Save();
		}

		private void P50_CheckedChanged(object? sender, EventArgs e) {
			if (GhostSpeedRadioButtons[0].Checked) {
				Program.window.GhostSpeed = 0;
				Settings.Default.GhostSpeed = 0;
				Settings.Default.Save();
			}
		}
		private void P75_CheckedChanged(object? sender, EventArgs e) {
			if (GhostSpeedRadioButtons[1].Checked) {
				Program.window.GhostSpeed = 1;
				Settings.Default.GhostSpeed = 1;
				Settings.Default.Save();
			}
		}
		private void P100_CheckedChanged(object? sender, EventArgs e) {
			if (GhostSpeedRadioButtons[2].Checked) {
				Program.window.GhostSpeed = 2;
				Settings.Default.GhostSpeed = 2;
				Settings.Default.Save();
			}
		}
		private void P125_CheckedChanged(object? sender, EventArgs e) {
			if (GhostSpeedRadioButtons[3].Checked) {
				Program.window.GhostSpeed = 3;
				Settings.Default.GhostSpeed = 3;
				Settings.Default.Save();
			}
		}
		private void P150_CheckedChanged(object? sender, EventArgs e) {
			if (GhostSpeedRadioButtons[4].Checked) {
				Program.window.GhostSpeed = 4;
				Settings.Default.GhostSpeed = 4;
				Settings.Default.Save();
			}
		}
		private void RecordGhostStep_Click(object sender, EventArgs e) {
			RecordGhostStepKeyTextbox.Focus();
		}
		private void ResetRecordGhostStepLabel_Click(object sender, EventArgs e) {
			ResetGhostStepKeyTextBox.Focus();
		}

		private void TimerLabel_Click(object sender, EventArgs e) {
			TimerKeyTextbox.Focus();
		}


		private void OpacityTextBox_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == 13) {
				OpacitySlider.Focus();
			}
			if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
				return;
			}
			e.Handled = true;
		}

		private void OpacityTextBox_TextChanged(object sender, EventArgs e) {
			int iMax = 100;
			if (OpacityTextBox.Text != null && OpacityTextBox.Text != "") {
				if (int.Parse(OpacityTextBox.Text) > iMax) {
					OpacityTextBox.Text = iMax.ToString();
				}
				OpacitySlider.Value = int.Parse(OpacityTextBox.Text);
			}
		}

		private void ReturnButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void OpacitySlider_ValueChanged(object sender, EventArgs e) {
			Opacity = OpacitySlider.Value / 100.0;
			OpacityTextBox.Text = OpacitySlider.Value.ToString();
			Program.window.Opacity = Opacity;
			Settings.Default.Opacity = Opacity;
			Settings.Default.Save();
		}
	}
}
