namespace Utilities.Text
{
	public static class Utilities
	{ 
		public static string Left(this string value, int length)
		{
			return string.IsNullOrEmpty(value)
				? value
				: value.Substring(0, Math.Min(length, value.Length));
		}
	}
}
