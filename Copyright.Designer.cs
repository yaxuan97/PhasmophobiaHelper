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
			label1 = new Label();
			linkLabel1 = new LinkLabel();
			linkLabel2 = new LinkLabel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 16);
			label1.Name = "label1";
			label1.Size = new Size(206, 17);
			label1.TabIndex = 0;
			label1.Text = "由yaxuan97制作。转发请注意版权。";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(11, 51);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(70, 17);
			linkLabel1.TabIndex = 1;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Bilibili 主页";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Location = new Point(87, 51);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(70, 17);
			linkLabel2.TabIndex = 2;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "Bilibili 主页";
			// 
			// Copyright
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(linkLabel2);
			Controls.Add(linkLabel1);
			Controls.Add(label1);
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

		private Label label1;
		private LinkLabel linkLabel1;
		private LinkLabel linkLabel2;
	}
}