namespace PhasmophobiaHelper {
	public static class Util {
		public static string KeyDataToString(Keys keydata){
			string result = "";
			if ((keydata & Keys.Control) != 0) {
				result += "Ctrl + ";
			}
			if ((keydata & Keys.Alt) != 0) {
				result += "Alt + ";
			}
			if ((keydata & Keys.Shift) != 0) {
				result += "Shift + ";
			}
			result += keydata.ToString().Split(',')[0];
			return result;
		}
	}
}
