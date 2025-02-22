namespace Utilities.Text.Tests;

public class RightMethodTests
{
	[Fact]
	public void Right_TakeRightMostCharacters_True()
	{
		//Arrange
		string textBefore = "Hello World!";

		//Act
		string textAfter = textBefore.Right(6);


		//Assert
		Assert.True(textAfter == "World!");
	}

	[Fact]
	public void Right_StringTooLongReturnsOriginalString_True()
	{
		//Arrange
		string textBefore = "Hello World!";

		//Act
		string textAfter = textBefore.Right(20);
		Console.WriteLine(textAfter);

		//Assert
		Assert.True(textAfter == "Hello World!");
	}

	[Fact]
	public void Right_StringIsNullReturnsOriginalString_True()
	{
		//Arrange
		string textBefore = null;

		//Act
		string textAfter = textBefore.Right(20);


		//Assert
		Assert.True(textAfter == null);
	}

	[Fact]
	public void Right_StringIsEmptyReturnsOriginalString_True()
	{
		//Arrange
		string textBefore = string.Empty;

		//Act
		string textAfter = textBefore.Right(20);


		//Assert
		Assert.True(textAfter == string.Empty);
	}
}