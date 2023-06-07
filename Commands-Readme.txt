* On command prompt, cd into your project folder (cd <Your-Project-folder>).

* To connect SQL  server from terminal:
	( Online-Auction /sqlcmd -S localhost -U sa -P pass@word1 )
	
	-To create database from terminal - 
	1> Create Database OnlineAuction_Db
	2> Go

* Steps to Apply Migration(Code first approach):
	Press Ctrl+C to get back to command prompt
	Run following command to apply migration-
             ( Online-Auction /dotnet-ef database update)

*  To check whether migrations are applied from terminal:
	( Online-Auction /sqlcmd -S localhost -U sa -P pass@word1 )
	1> Use OnlineAuction_Db
	2> Go
	1> Select * From __EFMigrationsHistory
	2> Go

* To build your project use command:
	( Online-Auction /dotnet build )

* To launch your application, Run the following command to run the application:
	( Online-Auction /dotnet run )

To run the test cases in CMD, Run the following command to test the application:

	( Online-Auction /dotnet test --logger "console;verbosity=detailed" )
 (You can run this command multiple times to identify the test case status,and   refactor code  to make maximum test cases passed before final submission).

* To ensure your code is saved and available for later use, remember to use the CTRL+Shift+B command on your code IDE.
   This will push or save the updated contents in the internal git/repository.
   It is also important to use CTRL+Shift+B before the final submission to evaluate the code quality.