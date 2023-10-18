using System.ComponentModel;
using System.Runtime.InteropServices;

namespace PhasmophobiaHelper {
	/// <summary>
	/// 可垂直对齐的单行文本框
	/// </summary>
	/// <creator>marc</creator>
	public class AlignableTextBox : TextBox {
		private VerticalAlignment _verticalAlignment = VerticalAlignment.Center;
		/// <summary>
		/// 垂直对齐方向。默认是垂直居中
		/// </summary>
		[Browsable(true)]
		[Category("CustomParam")]
		[Description("垂直对齐方向。默认是垂直居中")]
		public VerticalAlignment VerticalAlign {
			get {
				return _verticalAlignment;
			}
			set {
				_verticalAlignment = value;

				Align();
			}
		}

		/// <inheritdoc cref="AlignableTextBox"/>
		public AlignableTextBox() {
			Multiline = true;
			WordWrap = false;
		}

		/// <inheritdoc/>
		protected override void OnClientSizeChanged(EventArgs e) {
			base.OnClientSizeChanged(e);

			Align();
		}

		/// <inheritdoc/>
		protected override void OnTextChanged(EventArgs e) {
			base.OnTextChanged(e);

			Refresh();
		}

		/// <inheritdoc/>
		protected override void OnKeyPress(KeyPressEventArgs e) {
			base.OnKeyPress(e);

			//13表示回车
			if (e.KeyChar == 13) {
				e.Handled = true;
				return;
			}
		}

		/// <inheritdoc/>
		protected override void WndProc(ref Message m) {
			//0x0302是粘贴消息
			if (m.Msg == 0x0302) {
				Text = Clipboard.GetText(TextDataFormat.Text);

				//拦截此消息
				m.Result = IntPtr.Zero;
				return;
			}

			//若此消息不是粘贴消息，则交给其基类去处理
			base.WndProc(ref m);
		}

		/// <inheritdoc/>
		public override string Text {
			get {
				return base.Text;
			}
			set {
				base.Text = value.Split(Environment.NewLine).First();
			}
		}

		[DllImport("user32.dll", EntryPoint = "SendMessageA")]
		private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, ref Rectangle lParam);

		private const int EM_GETRECT = 0xB2;
		private const int EM_SETRECTNP = 0xB4;

		/// <summary>
		/// 对齐
		/// </summary>
		private void Align() {
			TextBox text = this;
			if (text.Multiline == false) {
				return;
			}

			Rectangle rc = new();
			_ = SendMessage(text.Handle, EM_GETRECT, IntPtr.Zero, ref rc);
			//文字的大小
			Size size = TextRenderer.MeasureText(" ", text.Font);

			if (VerticalAlign == VerticalAlignment.Top) {
				rc.Y = rc.Top - (rc.Bottom - rc.Top - size.Height) / 2;
			} else if (VerticalAlign == VerticalAlignment.Center) {
				rc.Y = (rc.Bottom - rc.Top - size.Height) / 2;
			} else if (VerticalAlign == VerticalAlignment.Bottom) {
				//rc.Y = rc.Height - size.Height - 2;
				rc.Y = rc.Top + (rc.Bottom - rc.Top - size.Height) / 2 - 2;
			}

			_ = SendMessage(text.Handle, EM_SETRECTNP, IntPtr.Zero, ref rc);

			text.Refresh();
		}

		/// <summary>
		/// 表示垂直对齐的方向
		/// </summary>
		/// <creator>marc</creator>
		public enum VerticalAlignment {
			/// <summary>
			/// 居上
			/// </summary>
			Top,
			/// <summary>
			/// 垂直居中
			/// </summary>
			Center,
			/// <summary>
			/// 居下
			/// </summary>
			Bottom,
		}
	}
}