using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookReservationApp.Migrations
{
    /// <inheritdoc />
    public partial class AddIdPKtoFavoriteModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "121b7952-ca49-45cb-b008-e09c2ae1476a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf64eb55-611d-4a89-8913-2f4a507d239a");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "874a13da-09a4-460b-a439-742969120a32", "222422fb-a60d-4ae5-8d33-6550cfd1b0a2", "Admin", "ADMIN" },
                    { "f625b892-5880-4f6f-b818-5806397b7a0a", "1d676aeb-3ded-4185-9d99-83444a8d5361", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "874a13da-09a4-460b-a439-742969120a32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f625b892-5880-4f6f-b818-5806397b7a0a");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Favorites");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "121b7952-ca49-45cb-b008-e09c2ae1476a", "adf29d60-fdfc-40c3-884c-62086134b080", "User", "USER" },
                    { "bf64eb55-611d-4a89-8913-2f4a507d239a", "4b3d30af-a3a9-4323-898e-47d427f154a3", "Admin", "ADMIN" }
                });
        }
    }
}
