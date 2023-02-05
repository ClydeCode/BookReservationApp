using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookReservationApp.Migrations
{
    /// <inheritdoc />
    public partial class AddImageURLfieldtoBookModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5fa0102-1642-407f-b31a-e4f4580f7fe1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca4df2e4-7619-4923-a531-92b14723c99e");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b493f2e-c6e7-47ee-a4cb-276f7e97f082", "8bc2b52a-9263-4ec0-9164-07092b9b8638", "User", "USER" },
                    { "b90b1bf6-68c6-41f8-8fcd-28c749f4258b", "ad08f199-ebb7-423f-a3fc-43298771adda", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b493f2e-c6e7-47ee-a4cb-276f7e97f082");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b90b1bf6-68c6-41f8-8fcd-28c749f4258b");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5fa0102-1642-407f-b31a-e4f4580f7fe1", "f11400e2-ecb4-4972-97a1-e40a10e14915", "User", "USER" },
                    { "ca4df2e4-7619-4923-a531-92b14723c99e", "ef9dfc12-f189-46db-a0a8-5b44b506a396", "Admin", "ADMIN" }
                });
        }
    }
}
