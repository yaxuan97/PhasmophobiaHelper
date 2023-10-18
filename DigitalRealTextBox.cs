namespace PhasmophobiaHelper {
	public class DigitalRealTextBox : TextBox {
		protected override void OnTextChanged(EventArgs e) {
			base.OnTextChanged(e);
			if (Text is not null and not "") {
				var txt = Text.Split('.');
				if (txt.Length > 1) {
					Text = txt[0] + "." + txt[1];
				}
			}
		}
		protected override void OnKeyPress(KeyPressEventArgs e) {
			base.OnKeyPress(e);
			if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == '.')) {
				return;
			}
			e.Handled = true;
		}
	}
}
