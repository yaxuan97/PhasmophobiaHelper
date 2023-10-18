using PhasmophobiaHelper.Properties;
using System.Runtime.InteropServices;

namespace PhasmophobiaHelper {
	public partial class MainWindow : Form {
		public int GhostSpeed = 2;
		public Keys RecordGhostStepKeyBinding = Keys.D1;
		public Keys StopRecordGhostStepKeyBinding = Keys.D2;
		public Keys TimerKeyBinding = Keys.D3;
		private static readonly string[] GhostSpeeds = { "50%", "75%", "100%", "125%", "150%" };
		private static readonly KeyboardHook k_hook = new();
		public Setting? settingForm;

		[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		public const uint SWP_NOMOVE = 0x2;
		public const uint SWP_NOSIZE = 0x1;
		public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

		public MainWindow() {
			InitializeComponent();
			FuckVs();
			k_hook.KeyDownEvent += new KeyEventHandler(Hook_KeyDown);//钩住键按下
			k_hook.Start();
			GhostSpeed = Settings.Default.GhostSpeed;
			RecordGhostStepKeyBinding = (Keys)Settings.Default.RecordGhostSpeedKeyBinding;
			StopRecordGhostStepKeyBinding = (Keys)Settings.Default.ResetGhostSpeedKeyBinding;
			TimerKeyBinding = (Keys)Settings.Default.TimerKeyBinding;
			Opacity = Settings.Default.Opacity;
			TopMost = false;
		}

		/// <summary>
		///  Fuck VS: Don't Change My Code!!!
		/// </summary>
		private void FuckVs() {

		}

		private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
			k_hook.Stop();
		}
		private void Hook_KeyDown(object? sender, KeyEventArgs e) {
			if (e.KeyData == TimerKeyBinding) {
				GhostTimer.Enabled = true;
				GhostTimer.Stop();
				TimerProgress.Value = 0;
				GhostTimer.Start();
				TimerTextLabel.Text = Util.SecondToTimeMMSS(TimerProgress.Value);
			}
		}

		private void GhostTimer_Tick(object sender, EventArgs e) {
			TimerProgress.PerformStep();
			TimerTextLabel.Text = Util.SecondToTimeMMSS(TimerProgress.Value);
		}

		private void SettingButton_Click(object sender, EventArgs e) {
			settingForm ??= new();
			settingForm.ShowDialog();
		}

		private void TopMostButton_Click(object sender, EventArgs e) {
			TopMost = !TopMost;
			if (TopMost) {
				SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
				TopMostButton.Text = "取消窗口置顶";
				FormBorderStyle = FormBorderStyle.None;
			} else {
				SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
				TopMostButton.Text = "窗口置顶";
				FormBorderStyle = FormBorderStyle.FixedDialog;
			}
		}

		private void TimerGroup_Enter(object sender, EventArgs e) {

		}

		private void TimerGroup_Paint(object sender, PaintEventArgs e) {
			var graphics = e.Graphics;
		}
	}
}