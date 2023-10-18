namespace PhasmophobiaHelper {
	internal static class Program {
		public static MainWindow window = new();
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
			System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
			if (!principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)) {
				var result = MessageBox.Show(
				"如果你的游戏是在管理员模式下运行的，此程序需要也以管理员模式运行，否则将无法在你玩游戏的同时监听键盘。是否要以管理员模式运行程序？",
				"权限提醒",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
				);
				if (result == DialogResult.Yes) {
					System.Diagnostics.ProcessStartInfo startInfo = new() {
						UseShellExecute = true,
						WorkingDirectory = Environment.CurrentDirectory,
						FileName = Application.ExecutablePath,
						Verb = "runas"
					};
					try {
						System.Diagnostics.Process.Start(startInfo);
					} catch {
						return;
					}
					Application.Exit();
					return;
				}
			}
			ApplicationConfiguration.Initialize();
			Application.Run(window);
		}
	}
}