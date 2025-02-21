namespace Utilities.Text.Tests
{
	public class Tests
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
}
