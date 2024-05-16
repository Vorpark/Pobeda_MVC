using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewSeedProducts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductProductTag",
                columns: new[] { "ProductsId", "TagsId" },
                values: new object[,]
                {
                    { 3, 4 },
                    { 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 4, 2 });
        }
    }
}
