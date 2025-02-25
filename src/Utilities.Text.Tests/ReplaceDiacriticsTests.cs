using Xunit;

public class ReplaceDiacriticsTests
{
	[Fact]
	public void RemoveDiacritics_NullString_ReturnsNull()
	{
		// Arrange
		string? value = null;
		// Act
		string result = value.ReplaceDiacritics();
		// Assert
		Assert.Null(result);
	}

	[Fact]
	public void RemoveDiacritics_EmptyString_ReturnsEmptyString()
	{
		// Arrange
		string value = string.Empty;
		// Act
		string result = value.ReplaceDiacritics();
		// Assert
		Assert.Equal(string.Empty, result);
	}

	[Fact]
	public void RemoveDiacritics_StringWithoutDiacritics_ReturnsSameString()
	{
		// Arrange
		string value = "Hello, World!";
		// Act
		string result = value.ReplaceDiacritics();
		// Assert
		Assert.Equal(value, result);
	}

	[Fact]
	public void RemoveDiacritics_StringWithDiacritics_ReturnsStringWithoutDiacritics()
	{
		// Arrange
		string value = "Héllô, Wôrld!";
		// Act
		string result = value.ReplaceDiacritics();
		// Assert
		Assert.Equal("Hello, World!", result);
	}
}
