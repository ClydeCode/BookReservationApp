using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookReservationApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFKtoBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "042a4a38-2d7c-42f6-822c-7885474e1ac1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06cb68f0-6985-4ae0-a882-10550cf30fd2");

            migrationBuilder.AlterColumn<string>(
                name: "ReservedBy",
                table: "Books",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5fa0102-1642-407f-b31a-e4f4580f7fe1", "f11400e2-ecb4-4972-97a1-e40a10e14915", "User", "USER" },
                    { "ca4df2e4-7619-4923-a531-92b14723c99e", "ef9dfc12-f189-46db-a0a8-5b44b506a396", "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_ReservedBy",
                table: "Books",
                column: "ReservedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_ReservedBy",
                table: "Books",
                column: "ReservedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_ReservedBy",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ReservedBy",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5fa0102-1642-407f-b31a-e4f4580f7fe1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca4df2e4-7619-4923-a531-92b14723c99e");

            migrationBuilder.AlterColumn<string>(
                name: "ReservedBy",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "042a4a38-2d7c-42f6-822c-7885474e1ac1", "ba6022da-a3af-441d-a464-ba60352214eb", "Admin", "ADMIN" },
                    { "06cb68f0-6985-4ae0-a882-10550cf30fd2", "73cefd6c-40a4-4749-af12-2cf3abe05873", "User", "USER" }
                });
        }
    }
}
