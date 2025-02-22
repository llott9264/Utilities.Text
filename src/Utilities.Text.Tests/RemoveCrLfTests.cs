namespace Utilities.Text.Tests;

public class RemoveCrLfTests
{
	[Fact]
	public void RemoveCrLf_StringIsEmpty_ReturnsEmptyString_True()
	{
		//Arrange
		string textBefore = string.Empty;

		//Act
		string textAfter = textBefore.RemoveCrLf();

		//Assert
		Assert.True(textAfter == string.Empty);
	}

	[Fact]
	public void RemoveCrLf_StringIsNull_ReturnsEmptyString_True()
	{
		//Arrange
		string textBefore = null;

		//Act
		string textAfter = textBefore.RemoveCrLf();

		//Assert
		Assert.True(textAfter == string.Empty);
	}

	[Fact]
	public void RemoveCrLf_StringHasCrLf_ReturnsStringWithoutCrLf_True()
	{
		//Arrange
		string textBefore = "Hell\n\ro World!";

		//Act
		string textAfter = textBefore.RemoveCrLf();

		//Assert
		Assert.True(textAfter == "Hello World!");
	}

	[Fact]
	public void RemoveCrLf_StringDoesNotHaveCrLf_ReturnsString_True()
	{
		//Arrange
		string textBefore = "Hello World!";

		//Act
		string textAfter = textBefore.RemoveCrLf();

		//Assert
		Assert.True(textAfter == "Hello World!");
	}
}