using PhasmophobiaHelper.Properties;
using System.Runtime.InteropServices;

namespace PhasmophobiaHelper {
	public partial class MainWindow : Form {
		public int GhostSpeed = 2;
		public Keys RecordGhostStepKeyBinding = Keys.D1;
		public Keys ResetRecordGhostStepKeyBinding = Keys.D2;
		public Keys TimerKeyBinding = Keys.D3;
		public int GhostStepQueueLength = 10;
		public decimal GhostGuessingOffset = 0.1M;
		public static readonly decimal[] GhostSpeeds = { 0.46M, 0.74M, 1.00M, 1.29M, 1.62M };
		private static readonly KeyboardHook k_hook = new();
		public Setting? settingForm;

		[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
		private static readonly Util.GhostStepConventer ghostStepConventer = new();
		public const uint SWP_NOMOVE = 0x2;
		public const uint SWP_NOSIZE = 0x1;
		public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

		public MainWindow() {
			InitializeComponent();
			CustomInitailize();
			k_hook.KeyDownEvent += new KeyEventHandler(Hook_KeyDown);//钩住键按下
			k_hook.Start();
			GhostSpeed = Settings.Default.GhostSpeed;
			RecordGhostStepKeyBinding = (Keys)Settings.Default.RecordGhostSpeedKeyBinding;
			ResetRecordGhostStepKeyBinding = (Keys)Settings.Default.ResetGhostSpeedKeyBinding;
			TimerKeyBinding = (Keys)Settings.Default.TimerKeyBinding;
			Opacity = Settings.Default.Opacity;
			GhostStepQueueLength = Settings.Default.GhostStepQueueLength;
			GhostGuessingOffset = Settings.Default.GhostGuessingOffset;
			TopMost = false;
		}
		private void CustomInitailize() {

		}

		private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
			k_hook.Stop();
		}
		private void Hook_KeyDown(object? sender, KeyEventArgs e) {
			if (e.KeyData == TimerKeyBinding) {
				GhostTimer.Enabled = true;
				GhostTimer.Stop();
				TimerProgress.ResetValue();
				GhostTimer.Start();
				TimerTextLabel.Text = Util.SecondToTimeMMSS(TimerProgress.Value);
				DemonHuntingColdDownLabel.ForeColor = Color.ForestGreen;
				GhostHuntingColdDownLabel.ForeColor = Color.ForestGreen;
				DemonIncenseColdDownLabel.ForeColor = Color.ForestGreen;
				GhostIncenseColdDownLabel.ForeColor = Color.ForestGreen;
				SpiritIncenseColdDownLabel.ForeColor = Color.ForestGreen;
			} else if (e.KeyData == RecordGhostStepKeyBinding) {
				ghostStepConventer.AddStep();
				var speed = ghostStepConventer.GetSpeed();
				var speedText = speed.ToString("f2");
				SpeedResultLabel.Text = $"{speedText} m/s";
				GhostGuessingResultLabel.Text = Util.GuessGhostUseSpeed(speed, GhostGuessingOffset);
			} else if (e.KeyData == ResetRecordGhostStepKeyBinding) {
				ghostStepConventer.Reset();
				SpeedResultLabel.Text = "0.00 m/s";
				GhostGuessingResultLabel.Text = "N/A";
			}
		}

		private void GhostTimer_Tick(object sender, EventArgs e) {
			TimerProgress.PerformStep();
			TimerTextLabel.Text = Util.SecondToTimeMMSS(TimerProgress.Value);
			switch (TimerProgress.Value) {
				case 20:
					DemonHuntingColdDownLabel.ForeColor = Color.Red;
					break;
				case 25:
					GhostHuntingColdDownLabel.ForeColor = Color.Red;
					break;
				case 60:
					DemonIncenseColdDownLabel.ForeColor = Color.Red;
					break;
				case 90:
					GhostIncenseColdDownLabel.ForeColor = Color.Red;
					break;
				case 180:
					SpiritIncenseColdDownLabel.ForeColor = Color.Red;
					break;
			}
		}

		private void SettingButton_Click(object sender, EventArgs e) {
			settingForm ??= new();
			settingForm.ShowDialog();
		}

		private void TopMostButton_Click(object sender, EventArgs e) {
			TopMost = !TopMost;
			if (TopMost) {
				SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
				TopMostButton.Text = "取消置顶";
				FormBorderStyle = FormBorderStyle.None;
			} else {
				SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
				TopMostButton.Text = "窗口置顶";
				FormBorderStyle = FormBorderStyle.FixedDialog;
			}
		}

		private void TimerGroup_Paint(object sender, PaintEventArgs e) {
			var graphics = e.Graphics;
			// 在 20s 处画一条向下的线
			float startpoint_X = 20.0F / 180 * TimerProgress.Width + TimerProgress.Location.X;
			float startpoint_Y_Down = TimerProgress.Location.Y + TimerProgress.Height;
			float endpoint_X = startpoint_X;
			float endpoint_Y_Down = startpoint_Y_Down + 10;
			graphics.DrawLine(new Pen(Color.Black, 2), startpoint_X, startpoint_Y_Down, endpoint_X, endpoint_Y_Down);
			// 在 25s 处画一条向上的线
			startpoint_X = 25.0F / 180 * TimerProgress.Width + TimerProgress.Location.X;
			float startpoint_Y_Up = TimerProgress.Location.Y;
			endpoint_X = startpoint_X;
			float endpoint_Y_Up = startpoint_Y_Up - 10;
			graphics.DrawLine(new Pen(Color.Black, 2), startpoint_X, startpoint_Y_Up, endpoint_X, endpoint_Y_Up);
			// 在 60s 处画一条向下的线
			startpoint_X = 60.0F / 180 * TimerProgress.Width + TimerProgress.Location.X;
			endpoint_X = startpoint_X;
			graphics.DrawLine(new Pen(Color.Black, 2), startpoint_X, startpoint_Y_Down, endpoint_X, endpoint_Y_Down);
			// 在 90s 处画一条向上的线
			startpoint_X = 90.0F / 180 * TimerProgress.Width + TimerProgress.Location.X;
			endpoint_X = startpoint_X;
			graphics.DrawLine(new Pen(Color.Black, 2), startpoint_X, startpoint_Y_Up, endpoint_X, endpoint_Y_Up);
			// 在 180s 处画一条向下的线
			startpoint_X = 180.0F / 180 * TimerProgress.Width + TimerProgress.Location.X;
			endpoint_X = startpoint_X;
			graphics.DrawLine(new Pen(Color.Black, 2), startpoint_X, startpoint_Y_Down, endpoint_X, endpoint_Y_Down);
		}
	}
}