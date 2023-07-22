using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SipayApi.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Customer]([FirstName],[LastName],[CustomerNumber],[Address],[IsActive],[InsertDate],[InsertUser])VALUES('Denny1','Sellen',10001,'Istanbul',1,'2023-02-02','SystemAdmin');");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Customer]([FirstName],[LastName],[CustomerNumber],[Address],[IsActive],[InsertDate],[InsertUser])VALUES('Denny2','Sellen',10002,'Istanbul',1,'2023-02-02','SystemAdmin');");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Customer]([FirstName],[LastName],[CustomerNumber],[Address],[IsActive],[InsertDate],[InsertUser])VALUES('Denny3','Sellen',10003,'Istanbul',1,'2023-02-02','SystemAdmin');");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Customer]([FirstName],[LastName],[CustomerNumber],[Address],[IsActive],[InsertDate],[InsertUser])VALUES('Denny4','Sellen',10004,'Istanbul',1,'2023-02-02','SystemAdmin');");

            migrationBuilder.Sql(@"INSERT INTO [dbo].[Account]([CustomerNumber],[Balance],[Name],[OpenDate],[CurrencyCode],[AccountNumber],[IsActive],[InsertDate],[InsertUser])VALUES(10001,0,'Denny1','2023-06-02','TRY',50001,1,'2023-07-02','SystemAdmin')");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Account]([CustomerNumber],[Balance],[Name],[OpenDate],[CurrencyCode],[AccountNumber],[IsActive],[InsertDate],[InsertUser])VALUES(10002,0,'Denny2','2023-06-02','TRY',50002,1,'2023-07-02','SystemAdmin')");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Account]([CustomerNumber],[Balance],[Name],[OpenDate],[CurrencyCode],[AccountNumber],[IsActive],[InsertDate],[InsertUser])VALUES(10003,0,'Denny3','2023-06-02','TRY',50003,1,'2023-07-02','SystemAdmin')");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Account]([CustomerNumber],[Balance],[Name],[OpenDate],[CurrencyCode],[AccountNumber],[IsActive],[InsertDate],[InsertUser])VALUES(10004,0,'Denny4','2023-06-02','TRY',50004,1,'2023-07-02','SystemAdmin')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
