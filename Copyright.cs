namespace PhasmophobiaHelper {
	public partial class Copyright : Form {
		public Copyright() {
			InitializeComponent();
		}

		private void BilibiliLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("explorer.exe", "https://space.bilibili.com/8563083");
		}

		private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("explorer.exe", "https://github.com/yaxuan97/PhasmophobiaHelper");
		}
	}
}
