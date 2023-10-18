namespace PhasmophobiaHelper {
	partial class Copyright {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			CopyrightLabel = new Label();
			BilibiliLink = new LinkLabel();
			GithubLink = new LinkLabel();
			SuspendLayout();
			// 
			// CopyrightLabel
			// 
			CopyrightLabel.AutoSize = true;
			CopyrightLabel.Location = new Point(11, 16);
			CopyrightLabel.Name = "CopyrightLabel";
			CopyrightLabel.Size = new Size(206, 17);
			CopyrightLabel.TabIndex = 0;
			CopyrightLabel.Text = "由yaxuan97制作。转发请注意版权。";
			// 
			// BilibiliLink
			// 
			BilibiliLink.AutoSize = true;
			BilibiliLink.Location = new Point(11, 51);
			BilibiliLink.Name = "BilibiliLink";
			BilibiliLink.Size = new Size(70, 17);
			BilibiliLink.TabIndex = 1;
			BilibiliLink.TabStop = true;
			BilibiliLink.Text = "Bilibili 主页";
			BilibiliLink.LinkClicked += BilibiliLink_LinkClicked;
			// 
			// GithubLink
			// 
			GithubLink.AutoSize = true;
			GithubLink.Location = new Point(87, 51);
			GithubLink.Name = "GithubLink";
			GithubLink.Size = new Size(46, 17);
			GithubLink.TabIndex = 2;
			GithubLink.TabStop = true;
			GithubLink.Text = "Github";
			GithubLink.LinkClicked += GithubLink_LinkClicked;
			// 
			// Copyright
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(224, 83);
			Controls.Add(GithubLink);
			Controls.Add(BilibiliLink);
			Controls.Add(CopyrightLabel);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "Copyright";
			ShowIcon = false;
			ShowInTaskbar = false;
			Text = "关于";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label CopyrightLabel;
		private LinkLabel BilibiliLink;
		private LinkLabel GithubLink;
	}
}