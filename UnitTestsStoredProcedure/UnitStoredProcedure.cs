using C_FirstTask;

namespace UnitTestsStoredProcedure
{
	public class UnitStoredProcedure
	{
		[Fact]
		public void TestCreateOrAlterStoredProcedureWithAllBrackets()
		{
		
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]",result);
		}

		[Fact]
		public void TestCreateOrAlterStoredProcedureWithSpaceWithAllBrackets()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [dbo].[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]
		public void TestCreateOrAlterStoredProcedureWithouthDboWithBrackets()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]
		public void TestCreateOrAlterStoredProcedureWithSpaceWithouthDboWithAllBrackets()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboBrackets()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithouthDboBracketsWithSpace()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE dbo.[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithouthDboWithouhBracketsWithouthSpace()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboWithouhBracketsWithouthSpace()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE dbo.bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboWithBracketsWithouthSpace()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [dbo].bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboWithAllBracketsWithouthSpace()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}


		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboWithAllBracketsWithSpace()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [dbo].[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboBracketsWithSpace()
		{
			
			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE dbo.[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboWithBracketsWithSpace()
		{

			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE [dbo].bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboWithouthSpace()
		{

			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE dbo.[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]

		public void TestCreateOrAlterStoredProcedureWithDboWithouthSpaceBrackets()
		{

			// Arrange
			string storedProcedure = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER PROCEDURE dbo.bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(storedProcedure);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}


	}
}