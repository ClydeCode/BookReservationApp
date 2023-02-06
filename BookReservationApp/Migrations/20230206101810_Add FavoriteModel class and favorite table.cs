using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookReservationApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFavoriteModelclassandfavoritetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b493f2e-c6e7-47ee-a4cb-276f7e97f082");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b90b1bf6-68c6-41f8-8fcd-28c749f4258b");

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "121b7952-ca49-45cb-b008-e09c2ae1476a", "adf29d60-fdfc-40c3-884c-62086134b080", "User", "USER" },
                    { "bf64eb55-611d-4a89-8913-2f4a507d239a", "4b3d30af-a3a9-4323-898e-47d427f154a3", "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_BookId",
                table: "Favorites",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "121b7952-ca49-45cb-b008-e09c2ae1476a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf64eb55-611d-4a89-8913-2f4a507d239a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b493f2e-c6e7-47ee-a4cb-276f7e97f082", "8bc2b52a-9263-4ec0-9164-07092b9b8638", "User", "USER" },
                    { "b90b1bf6-68c6-41f8-8fcd-28c749f4258b", "ad08f199-ebb7-423f-a3fc-43298771adda", "Admin", "ADMIN" }
                });
        }
    }
}
