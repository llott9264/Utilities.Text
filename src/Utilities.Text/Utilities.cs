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

		public static string Right(this string value, int length)
		{
			return string.IsNullOrEmpty(value)
				? value
				: value.Substring(Math.Max(0, value.Length - length));
		}
		
		public static string RemoveCharacters(this string value, List<string> charactersToRemove)
		{
			return string.IsNullOrEmpty(value)
				? string.Empty
				: charactersToRemove.Aggregate(value, (current, s) => current.Replace(s, "")).Trim();
		}

		public static string RemoveCrLf(this string value)
		{
			return RemoveCharacters(value, ["\n", "\r"]);
		}
	}
}
