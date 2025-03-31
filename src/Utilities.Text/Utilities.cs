using System.Globalization;
using System.Text;

namespace Utilities.Text;

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
		Dictionary<string, string> charactersToReplace = new();
		charactersToRemove.ForEach(s => charactersToReplace.Add(s, ""));
		return ReplaceCharacters(value, charactersToReplace);
	}

	public static string RemoveCrLf(this string value)
	{
		return RemoveCharacters(value, ["\n", "\r"]);
	}

	public static string ReplaceCharacters(this string value, Dictionary<string, string> charactersToReplace)
	{
		return string.IsNullOrEmpty(value)
			? string.Empty
			: charactersToReplace.Aggregate(value,
				(current, keyValuePair) => current.Replace(keyValuePair.Key, keyValuePair.Value));
	}

	public static string ReplaceDiacritics(this string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}

		string normalizedString = value.Normalize(NormalizationForm.FormD);
		StringBuilder stringBuilder = new();

		foreach (char c in normalizedString)
		{
			UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
			if (unicodeCategory != UnicodeCategory.NonSpacingMark)
			{
				stringBuilder.Append(c);
			}
		}

		return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
	}
}
