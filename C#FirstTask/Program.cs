using System.Text.RegularExpressions;

namespace C_FirstTask
{
	public class Program
	{
		static void Main(string[] args)
		{
			string sqlQuery = @"SET QUOTED_IDENTIFIER ON
                                SET ANSI_NULLS ON
                                GO
                                CREATE OR ALTER PROCEDURE [dbo].[bcFillFormBankClient_2] @FormName AS NVARCHAR(100) = '', @UpdateTable AS NVARCHAR(100)='', 
											                 @PrimaryKey AS NVARCHAR(100), @PrimaryKeyValue AS INT, @Lng AS NVARCHAR(10) = 'ENG', 
											                 @ActivityKey AS NVARCHAR(50) = NULL, @bagsUserApplicationLogID INT = NULL--@PrimaryKeyValue=@rContactID INT 
                                --WITH ENCRYPTION
                                  AS
                                  /**********************************************************************************************************
                                 * Description: 
	                               Procedure for Personal Information
                                 * Input parameters:

                                 * Outupt parameters:

                                 * Created: 

                                 * Modified:

                                 * Cal example

                                 * Note
                                 ****************************************************************************************************************/
                                 -----------------------------------------------------------------------------------------------------------------
                                 DECLARE @Type INT, @PersonalNumber NVARCHAR(MAX), 
		                                 @FirstName NVARCHAR(MAX), @LastName NVARCHAR(MAX), 
		                                 @BirthDate NVARCHAR(MAX), @IdentityCard NVARCHAR(MAX), 
		                                 @PassportNumber NVARCHAR(MAX), @DrivingLicence NVARCHAR(MAX)
                                 DECLARE @ShortName NVARCHAR(MAX), @RegistrationNumber NVARCHAR(MAX), 
		                                 @FullName NVARCHAR(MAX), @VatNumber NVARCHAR(MAX), 
		                                 @RegistrationDate NVARCHAR(MAX), @ContactType NVARCHAR(MAX), 
		                                 @LastDateUpdated NVARCHAR(MAX)

                                 SELECT @Lng = DefaultLanguage FROM dbo.bagsUserApplicationLog WHERE bagsUserApplicationLogID = @bagsUserApplicationLogID
";

			var result = ExtractProcedure(sqlQuery);
			Console.WriteLine(result);


		}

		public static string ExtractProcedure(string query)
		{
			var result = Regex.Match(query, @"(CREATE\sOR\sALTER|CREATE|ALTER)\s(PROCEDURE|FUNCTION|VIEW)\s(\[dbo\]\.|dbo\.)*(\w+|\[\w+\s*\w+\]|)", RegexOptions.IgnoreCase);

			if (result.Success)
			{
				return result.Groups[4].Value;
			}
			else 
			{
				return "Invalid name!";
			}
		}
	}
}