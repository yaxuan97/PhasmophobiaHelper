using System.ComponentModel;

namespace PhasmophobiaHelper {
	public partial class NoDelayprogress : Panel {
		public NoDelayprogress() { DoubleBuffered = true; }
		[Browsable(true)]
		[Category("ProgressValue")]
		public int MaxValue { get; set; } = 100;
		[Browsable(true)]
		[Category("ProgressValue")]
		public int MinValue { get; set; } = 0;
		[Browsable(true)]
		[Category("ProgressValue")]
		public int Value { get; set; } = 0;
		[Browsable(true)]
		[Category("ProgressValue")]
		public int Step { get; set; } = 1;
		protected override void OnPaint(PaintEventArgs e) {
			var g = e.Graphics;
			var brush = new SolidBrush(BackColor);
			var pen = new Pen(brush);
			var rect = new Rectangle(0, 0, Width, Height);
			var rect2 = new Rectangle(0, 0, (int)(Width * (Value / (double)MaxValue)), Height);
			g.FillRectangle(brush, rect);
			g.DrawRectangle(pen, rect);
			g.FillRectangle(new SolidBrush(ForeColor), rect2);
		}
		public void PerformStep() {
			if (Value + Step <= MaxValue) {
				Value += Step;
			} else {
				Value = MaxValue;
			}
			Refresh();
		}
		public void ResetValue() {
			Value = MinValue;
			Refresh();
		}
	}
}

