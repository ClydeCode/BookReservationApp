using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookReservationApp.Migrations
{
    /// <inheritdoc />
    public partial class Addroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "042a4a38-2d7c-42f6-822c-7885474e1ac1", "ba6022da-a3af-441d-a464-ba60352214eb", "Admin", "ADMIN" },
                    { "06cb68f0-6985-4ae0-a882-10550cf30fd2", "73cefd6c-40a4-4749-af12-2cf3abe05873", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "042a4a38-2d7c-42f6-822c-7885474e1ac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06cb68f0-6985-4ae0-a882-10550cf30fd2");
        }
    }
}
