using System.ComponentModel;

namespace PhasmophobiaHelper {
	public class DigitalIntTextBox : TextBox {
		[Browsable(true)]
		[Category("DigitalTextBoxValue")]
		public int MaxValue { get; set; } = int.MaxValue;
		protected override void OnTextChanged(EventArgs e) {
			base.OnTextChanged(e);
			if (Text is not null and not "") {
				if (int.Parse(Text) > MaxValue) {
					Text = MaxValue.ToString();
				}
			}
		}
		protected override void OnKeyPress(KeyPressEventArgs e) {
			base.OnKeyPress(e);
			if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) {
				return;
			}
			e.Handled = true;
		}
	}
}
