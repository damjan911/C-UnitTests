using C_FirstTask;
namespace UnitTestsViews
{
	public class UnitView
	{
		[Fact]
		public void TestCreateOrAlterViewWithAllBrackets()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]
		public void TestCreateOrAlterViewWithSpaceWithAllBrackets()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [dbo].[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]
		public void TestCreateOrAlterViewWithouthDboWithBrackets()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]
		public void TestCreateOrAlterViewWithSpaceWithouthDboWithAllBrackets()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboBrackets()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithouthDboBracketsWithSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW dbo.[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithouthDboWithouhBracketsWithouthSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboWithouhBracketsWithouthSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW dbo.bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboWithBracketsWithouthSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [dbo].bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboWithAllBracketsWithouthSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}


		[Fact]

		public void TestCreateOrAlterViewWithDboWithAllBracketsWithSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [dbo].[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboBracketsWithSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW dbo.[bcFillFormBankClient 2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient 2]", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboWithBracketsWithSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW [dbo].bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboWithouthSpace()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW dbo.[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("[bcFillFormBankClient_2]", result);
		}

		[Fact]

		public void TestCreateOrAlterViewWithDboWithouthSpaceBrackets()
		{

			// Arrange
			string view = @"SET QUOTED_IDENTIFIER ON
							           SET ANSI_NULLS ON
							           GO
							           CREATE OR ALTER VIEW dbo.bcFillFormBankClient_2 @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100) = '', 
																		   @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
																		   @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue = @rContactID INT
							           --WITH ENCRYPTION
							           AS
							           CODE_CODE_CODE_CODE
						           ";

			// Act

			string result = Program.ExtractProcedure(view);

			// Assert

			Assert.Equal("bcFillFormBankClient_2", result);
		}
	}
}