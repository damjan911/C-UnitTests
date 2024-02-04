using C_FirstTask;
namespace UnitTestsFunctions
{
	public class UnitFunction
	{
		[Fact]
		public void TestCreateOrAlterFunctionWithAllBrackets()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]
		public void TestCreateOrAlterFunctionWithSpaceWithAllBrackets()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [dbo].[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]
		public void TestCreateOrAlterFunctionWithouthDboWithBrackets()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]
		public void TestCreateOrAlterFunctionWithSpaceWithouthDboWithAllBrackets()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboBrackets()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithouthDboBracketsWithSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION dbo.[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithouthDboWithouhBracketsWithouthSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboWithouhBracketsWithouthSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION dbo.bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboWithBracketsWithouthSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [dbo].bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboWithAllBracketsWithouthSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}


		[Fact]

		public void TestCreateOrAlterFunctionWithDboWithAllBracketsWithSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [dbo].[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboBracketsWithSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION dbo.[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboWithBracketsWithSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION [dbo].bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboWithouthSpace()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION dbo.[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]

		public void TestCreateOrAlterFunctionWithDboWithouthSpaceBrackets()
		{

			// Arrange
			string function = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER FUNCTION dbo.bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(function);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}


	}
}
