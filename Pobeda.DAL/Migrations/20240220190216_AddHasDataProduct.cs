using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddHasDataProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "City", "Description", "ImageUrl", "Name", "Price", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "Самара", "Состояние хорошее.", "\\products_image\\product_photo_1.webp", "Системный блок", 59000.0, 8 },
                    { 2, "Саратов", "Состояние хорошее.", "\\products_image\\product_photo_2.webp", "Apple iPhone SE 128GB", 11900.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductCharacteristics",
                columns: new[] { "Id", "Key", "ProductId", "Value" },
                values: new object[,]
                {
                    { 1, "Объем оперативной памяти", 1, "32 ГБ" },
                    { 2, "Тактовая частота процессора", 1, "2600 МГц" },
                    { 3, "Количество ядер процессора", 1, "6" },
                    { 4, "Тип оперативной памяти", 1, "DDR4" },
                    { 5, "Диагональ", 2, "4 дюйм." },
                    { 6, "Объем встроенной памяти", 2, "128 ГБ" },
                    { 7, "Объем оперативной памяти", 2, "2 ГБ" },
                    { 8, "Количество ядер процессора", 2, "2" }
                });

            migrationBuilder.InsertData(
                table: "ProductProductTag",
                columns: new[] { "ProductsId", "TagsId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductCharacteristics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductProductTag",
                keyColumns: new[] { "ProductsId", "TagsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
