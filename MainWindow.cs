using PhasmophobiaHelper.Properties;

namespace PhasmophobiaHelper {
	public partial class MainWindow : Form {
		private static readonly string[] GhostSpeeds = { "50%", "75%", "100%", "125%", "150%" };
		internal static int GhostSpeed = 2;
		internal static Keys RecordGhostStepKeyBinding = Keys.D1;
		//private static Key
		public MainWindow() {
			InitializeComponent();
			KeyboardHook k_hook = new();
			k_hook.KeyDownEvent += new KeyEventHandler(Hook_KeyDown);//钩住键按下
			k_hook.Start();
			GhostSpeed = Settings.Default.GhostSpeed;
			GhostSpeedRadioButtons[GhostSpeed].Checked = true;
			RecordGhostStepKeyBinding = (Keys)Settings.Default.RecordGhostSpeedKeyBinding;
			RecordGhostStepKey.Text = Util.KeyDataToString((Keys)Settings.Default.RecordGhostSpeedKeyBinding);
		}
		private void Hook_KeyDown(object sender, KeyEventArgs e) {
			//判断按下的键（Alt + A）
			if (e.KeyValue == (int)Keys.A && (int)ModifierKeys == (int)Keys.Alt) {
				//MessageBox.Show("按下了指定快捷键组合");
			}
		}
		private void RecordGhostStep_Click(object sender, EventArgs e) {
			RecordGhostStepKey.Focus();
		}
		private void RecordGhostStepKey_KeyDown(object sender, KeyEventArgs e) {
			RecordGhostStepKeyBinding = e.KeyData;
			RecordGhostStepKey.Text = Util.KeyDataToString(e.KeyData);
			Settings.Default.RecordGhostSpeedKeyBinding = (int)e.KeyData;
			Settings.Default.Save();
		}





		private void P50_CheckedChanged(object sender, EventArgs e) {
			if (GhostSpeedRadioButtons[0].Checked) {
				GhostSpeed = 0;
				Settings.Default.GhostSpeed = 0;
				Settings.Default.Save();
			}
		}
		private void P75_CheckedChanged(object sender, EventArgs e) {
			if (GhostSpeedRadioButtons[1].Checked) {
				GhostSpeed = 1;
				Settings.Default.GhostSpeed = 1;
				Settings.Default.Save();
			}
		}
		private void P100_CheckedChanged(object sender, EventArgs e) {
			if (GhostSpeedRadioButtons[2].Checked) {
				GhostSpeed = 2;
				Settings.Default.GhostSpeed = 2;
				Settings.Default.Save();
			}
		}
		private void P125_CheckedChanged(object sender, EventArgs e) {
			if (GhostSpeedRadioButtons[3].Checked) {
				GhostSpeed = 3;
				Settings.Default.GhostSpeed = 3;
				Settings.Default.Save();
			}
		}
		private void P150_CheckedChanged(object sender, EventArgs e) {
			if (GhostSpeedRadioButtons[4].Checked) {
				GhostSpeed = 4;
				Settings.Default.GhostSpeed = 4;
				Settings.Default.Save();
			}
		}
	}
}