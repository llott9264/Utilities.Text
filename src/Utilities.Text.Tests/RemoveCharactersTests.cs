namespace Utilities.Text.Tests;

public class RemoveCharactersTests
{
	[Fact]
	public void RemoveCharacters_StringIsNull_ReturnsEmptyString_True()
	{
		//Arrange
		string textBefore = null;
		List<string> charactersToRemove = new List<string> { "o", "l" };

		//Act
		string textAfter = textBefore.RemoveCharacters(charactersToRemove);

		//Assert
		Assert.True(textAfter == string.Empty);
	}

	[Fact]
	public void RemoveCharacters_StringIsEmpty_ReturnsEmptyString_True()
	{
		//Arrange
		string textBefore = string.Empty;
		List<string> charactersToRemove = new List<string> { "o", "l" };

		//Act
		string textAfter = textBefore.RemoveCharacters(charactersToRemove);

		//Assert
		Assert.True(textAfter == string.Empty);
	}

	[Fact]
	public void RemoveCharacters_StringHasCharactersToRemove_ReturnsStringWithoutCharacters_True()
	{
		//Arrange
		string textBefore = "Hello World!";
		List<string> charactersToRemove = new List<string> { "o", "l" };

		//Act
		string textAfter = textBefore.RemoveCharacters(charactersToRemove);

		//Assert
		Assert.True(textAfter == "He Wrd!");
	}

	[Fact]
	public void RemoveCharacters_StringDoesNotHaveCharactersToRemove_ReturnsString_True()
	{
		//Arrange
		string textBefore = "Hello World!";
		List<string> charactersToRemove = new List<string> { "z", "x" };

		//Act
		string textAfter = textBefore.RemoveCharacters(charactersToRemove);

		//Assert
		Assert.True(textAfter == "Hello World!");
	}
}