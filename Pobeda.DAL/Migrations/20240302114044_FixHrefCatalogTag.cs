using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixHrefCatalogTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 16,
                column: "Href",
                value: "/catalog/kompyuternaya-tehnika/klaviatury/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 17,
                column: "Href",
                value: "/catalog/kompyuternaya-tehnika/jestkie-diski/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 18,
                column: "Href",
                value: "/catalog/kompyuternaya-tehnika/printery-i-mfu/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 44,
                column: "Href",
                value: "/catalog/avto/radardetektory/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 70,
                column: "Href",
                value: "/catalog/audiotehnika/muzykalnye-centry/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 73,
                column: "Href",
                value: "/catalog/audiotehnika/domashnie-kinoteatry/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 81,
                column: "Href",
                value: "/catalog/tovary-dlya-detei/detskie-avtokresla/");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 16,
                column: "Href",
                value: "catalog/kompyuternaya-tehnika/klaviatury/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 17,
                column: "Href",
                value: "catalog/kompyuternaya-tehnika/jestkie-diski/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 18,
                column: "Href",
                value: "catalog/kompyuternaya-tehnika/printery-i-mfu/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 44,
                column: "Href",
                value: "catalog/avto/radardetektory/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 70,
                column: "Href",
                value: "catalog/audiotehnika/muzykalnye-centry/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 73,
                column: "Href",
                value: "catalog/audiotehnika/domashnie-kinoteatry/");

            migrationBuilder.UpdateData(
                table: "CategoryTags",
                keyColumn: "Id",
                keyValue: 81,
                column: "Href",
                value: "catalog/tovary-dlya-detei/detskie-avtokresla/");
        }
    }
}
