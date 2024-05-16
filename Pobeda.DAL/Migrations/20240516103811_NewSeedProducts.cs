using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewSeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "City", "Description", "ImageUrl", "Name", "Price", "SubCategoryId", "TranslitName" },
                values: new object[,]
                {
                    { 3, 1, "Самара", "Состояние отличное.", "\\products_image\\product_photo_3.webp", "Apple iPhone 11 64GB", 29900.0, 1, "apple-iphone-11-64gb" },
                    { 4, 1, "Саратов", "Состояние новый.", "\\products_image\\product_photo_4.webp", "Apple iPhone 12 128GB", 49900.0, 1, "apple-iphone-12-128gb" }
                });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Key", "ProductId", "Value" },
                values: new object[,]
                {
                    { 9, "Диагональ", 3, "6.1 дюйм." },
                    { 10, "Объем встроенной памяти", 3, "64 ГБ" },
                    { 11, "Объем оперативной памяти", 3, "4 ГБ" },
                    { 12, "Количество ядер процессора", 3, "6" },
                    { 13, "Диагональ", 4, "6.1 дюйм." },
                    { 14, "Объем встроенной памяти", 4, "128 ГБ" },
                    { 15, "Объем оперативной памяти", 4, "4 ГБ" },
                    { 16, "Количество ядер процессора", 4, "6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
