namespace PhasmophobiaHelper {
	internal static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			ApplicationConfiguration.Initialize();
			Application.Run(new MainWindow());
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
			//System.Security.Principal.WindowsPrincipal principal = new System.Security.Principal.WindowsPrincipal(identity);
			//// To customize application configuration such as set high DPI settings or default font,
			//// see https://aka.ms/applicationconfiguration.
			//if (principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)) {
			//	ApplicationConfiguration.Initialize();
			//	Application.Run(new MainWindow());
			//} else {
			//	System.Diagnostics.ProcessStartInfo startInfo = new() {
			//		UseShellExecute = true,
			//		WorkingDirectory = Environment.CurrentDirectory,
			//		FileName = Application.ExecutablePath,
			//		Verb = "runas"
			//	};
			//	try {
			//		System.Diagnostics.Process.Start(startInfo);
			//	} catch {
			//		return;
			//	}
			//	Application.Exit();
			//}
		}
	}
}