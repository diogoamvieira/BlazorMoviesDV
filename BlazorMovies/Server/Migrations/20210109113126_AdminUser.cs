using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    public partial class AdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
                    SET IDENTITY_INSERT [AspNetUsers] ON;
                INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
                VALUES (N'919aef45-3692-442a-8c2f-cf4384bc48dd', 0, N'17cc9731-2323-4d1a-a93b-e4be74e3293b', N'diogo@gmail.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'diogo@gmail.com', N'diogo@gmail.com', N'AQAAAAEAACcQAAAAEBWQsd0HYQFQe4kjlbeneZxbUZypv1EfZTsAA00fb6WAVZJFLOyfJA0GXbTN7DHBiQ==', NULL, CAST(0 AS bit), N'920a3d70-b877-4246-868d-5d6f9718f4cd', CAST(0 AS bit), N'diogo@gmail.com');
                IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
                    SET IDENTITY_INSERT [AspNetUsers] OFF;

                GO

                IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ClaimType', N'ClaimValue', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserClaims]'))
                    SET IDENTITY_INSERT [AspNetUserClaims] ON;
                INSERT INTO [AspNetUserClaims] ([Id], [ClaimType], [ClaimValue], [UserId])
                VALUES (1, N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Admin', N'919aef45-3692-442a-8c2f-cf4384bc48dd');
                IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ClaimType', N'ClaimValue', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserClaims]'))
                    SET IDENTITY_INSERT [AspNetUserClaims] OFF;

                GO

                INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
                VALUES (N'20210109113126_AdminUser', N'3.1.4');

                GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "919aef45-3692-442a-8c2f-cf4384bc48dd");
        }
    }
}
