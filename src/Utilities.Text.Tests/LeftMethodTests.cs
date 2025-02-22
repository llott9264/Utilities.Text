namespace Utilities.Text.Tests;

public class LeftMethodTests
{
	[Fact]
	public void Left_TakeLeftMostCharacters_True()
	{
		//Arrange
		string textBefore = "Hello World!";

		//Act
		string textAfter = textBefore.Left(6);


		//Assert
		Assert.True(textAfter == "Hello ");
	}

	[Fact]
	public void Left_StringTooLongReturnsOriginalString_True()
	{
		//Arrange
		string textBefore = "Hello World!";

		//Act
		string textAfter = textBefore.Left(20);

		//Assert
		Assert.True(textAfter == "Hello World!");
	}

	[Fact]
	public void Left_StringIsNullReturnsOriginalString_True()
	{
		//Arrange
		string textBefore = null;

		//Act
		string textAfter = textBefore.Left(20);


		//Assert
		Assert.True(textAfter == null);
	}

	[Fact]
	public void Left_StringIsEmptyNullReturnsOriginalString_True()
	{
		//Arrange
		string textBefore = string.Empty;

		//Act
		string textAfter = textBefore.Left(20);


		//Assert
		Assert.True(textAfter == string.Empty);
	}
}