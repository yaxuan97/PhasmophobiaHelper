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
				"��������Ϸ���ڹ���Աģʽ�����еģ��˳�����ҪҲ�Թ���Աģʽ���У������޷���������Ϸ��ͬʱ�������̡��Ƿ�Ҫ�Թ���Աģʽ���г���",
				"Ȩ������",
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