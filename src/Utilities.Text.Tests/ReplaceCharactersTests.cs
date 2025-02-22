namespace Utilities.Text.Tests;

public class ReplaceCharactersTests
{
	[Fact]
	public void ReplaceCharacters_StringIsNull_ReturnsEmptyString_True()
	{
		//Arrange
		string textBefore = null;
		Dictionary<string, string> charactersToReplace = new() { { "o", "l" } };

		//Act
		string textAfter = textBefore.ReplaceCharacters(charactersToReplace);

		//Assert
		Assert.True(textAfter == string.Empty);
	}

	[Fact]
	public void ReplaceCharacters_StringIsEmpty_ReturnsEmptyString_True()
	{
		//Arrange
		string textBefore = string.Empty;
		Dictionary<string, string> charactersToReplace = new() { { "o", "l" } };

		//Act
		string textAfter = textBefore.ReplaceCharacters(charactersToReplace);

		//Assert
		Assert.True(textAfter == string.Empty);
	}

	[Fact]
	public void ReplaceCharacters_StringHasCharactersToReplace_ReturnsStringWithoutCharacters_True()
	{
		//Arrange
		string textBefore = "Hello World!";
		Dictionary<string, string> charactersToReplace = new() { { "o", "l" } };

		//Act
		string textAfter = textBefore.ReplaceCharacters(charactersToReplace);

		//Assert
		Assert.True(textAfter == "Helll Wlrld!");
	}

	[Fact]
	public void ReplaceCharacters_StringDoesNotHaveCharactersToReplace_ReturnsString_True()
	{
		//Arrange
		string textBefore = "Hello World!";
		Dictionary<string, string> charactersToReplace = new() { { "z", "x" } };

		//Act
		string textAfter = textBefore.ReplaceCharacters(charactersToReplace);

		//Assert
		Assert.True(textAfter == "Hello World!");
	}
}