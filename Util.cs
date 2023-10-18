namespace PhasmophobiaHelper {
	public static class Util {
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
	}
}
