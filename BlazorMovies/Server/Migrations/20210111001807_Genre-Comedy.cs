using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    public partial class GenreComedy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "919aef45-3692-442a-8c2f-cf4384bc48dd");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Comedy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "919aef45-3692-442a-8c2f-cf4384bc48dd", 0, "17cc9731-2323-4d1a-a93b-e4be74e3293b", "diogo@gmail.com", true, false, null, "diogo@gmail.com", "diogo@gmail.com", "AQAAAAEAACcQAAAAEBWQsd0HYQFQe4kjlbeneZxbUZypv1EfZTsAA00fb6WAVZJFLOyfJA0GXbTN7DHBiQ==", null, false, "920a3d70-b877-4246-868d-5d6f9718f4cd", false, "diogo@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "919aef45-3692-442a-8c2f-cf4384bc48dd" });
        }
    }
}
