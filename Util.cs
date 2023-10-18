namespace PhasmophobiaHelper {
	public class Util {
		public static string KeyDataToString(Keys keydata) {
			switch (keydata) {
				case Keys.Control | Keys.ControlKey:
					return "Ctrl";
				case Keys.Alt | Keys.Menu:
					return "Alt";
				case Keys.Shift | Keys.ShiftKey:
					return "Shift";
			}
			string result = "";
			if ((keydata & Keys.Control) != 0)
				result += "Ctrl + ";
			if ((keydata & Keys.Alt) != 0)
				result += "Alt + ";
			if ((keydata & Keys.Shift) != 0)
				result += "Shift + ";
			result += keydata.ToString().Split(',')[0];
			return result;
		}
		public static string SecondToTimeMMSS(int second) {
			// 分钟数和秒数如果只有1位，要用0补齐2位
			string min = (second / 60).ToString().PadLeft(2, '0');
			string sec = (second % 60).ToString().PadLeft(2, '0');
			return $"{min}:{sec}";
		}
		public class GhostStepConventer {
			private readonly Queue<int> stepTime = new();
			private DateTime? lastStep;
			private int TimeSum = 0;
			public void AddStep() {
				DateTime now = DateTime.Now;
				if (lastStep != null) {
					var span = now - lastStep.Value;
					int milliseconds = span.Milliseconds;
					stepTime.Enqueue(milliseconds);
					TimeSum += milliseconds;
				}
				if (stepTime.Count > Program.window.GhostStepQueueLength) {
					TimeSum -= stepTime.Dequeue();
				}
				lastStep = now;
			}
			public void Reset() {
				stepTime.Clear();
				lastStep = null;
				TimeSum = 0;
			}
			private decimal GetAverageTime() {
				return TimeSum / stepTime.Count;
			}
			private static decimal AverageTimeToBpm(decimal timespan) {
				return 60000 / timespan;
			}
			private static decimal BpmToSpeed(decimal bpm) {
				decimal sm = MainWindow.GhostSpeeds[Program.window.GhostSpeed];
				return (decimal)((Math.Sqrt((double)((38400000 * (bpm / sm)) + 1687696201)) - 45341) / 19200);
			}
			public decimal GetSpeed() {
				return TimeSum == 0 ? 0 : BpmToSpeed(AverageTimeToBpm(GetAverageTime()));
			}
		}

		private static readonly Dictionary<string, decimal[]> SpecialGhosts = new();
		static Util() {
			SpecialGhosts.Add("亡魂", new decimal[] { 1.0M, 1.0M });
			SpecialGhosts.Add("寒魔", new decimal[] { 1.44M, 2.7M });
			SpecialGhosts.Add("孪魂-慢", new decimal[] { 1.53M, 1.53M });
			SpecialGhosts.Add("孪魂-快", new decimal[] { 1.87M, 1.87M });
			SpecialGhosts.Add("雷魂", new decimal[] { 2.5M, 2.5M });
			SpecialGhosts.Add("莫洛伊", new decimal[] { 1.5M, 2.25M });
			SpecialGhosts.Add("雾影", new decimal[] { 3.0M, 3.0M });
			SpecialGhosts.Add("刹耶", new decimal[] { 1.0M, 2.75M });
		}
		public static string GuessGhostUseSpeed(decimal speed, decimal offset) {
			string result = "";
			foreach (var Ghost in SpecialGhosts) {
				var min = Ghost.Value[0] - offset;
				var max = Ghost.Value[1] + offset;
				if (speed >= min && speed <= max)
					result += Ghost.Key + "；";
			}
			if (speed >= 1.70M - offset && speed <= 1.70M + offset)
				result += "所有常速鬼；";
			return result.Length > 0 ? result : "N/A";
		}
	}
}
