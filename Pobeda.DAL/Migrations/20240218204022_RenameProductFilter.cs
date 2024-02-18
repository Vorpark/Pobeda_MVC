using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RenameProductFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_Products_ProductId",
                table: "Characteristics");

            migrationBuilder.DropTable(
                name: "ProductProductFilter");

            migrationBuilder.DropTable(
                name: "ProductFilters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characteristics",
                table: "Characteristics");

            migrationBuilder.RenameTable(
                name: "Characteristics",
                newName: "ProductCharacteristics");

            migrationBuilder.RenameIndex(
                name: "IX_Characteristics_ProductId",
                table: "ProductCharacteristics",
                newName: "IX_ProductCharacteristics_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCharacteristics",
                table: "ProductCharacteristics",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductTag",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductTag", x => new { x.ProductsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_ProductProductTag_ProductTags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "ProductTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductTag_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "В кредит" },
                    { 2, "Состояние новый" },
                    { 3, "Состояние хорошее" },
                    { 4, "Состояние отличное" },
                    { 5, "Состояние удовлетворительное" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductTag_TagsId",
                table: "ProductProductTag",
                column: "TagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCharacteristics_Products_ProductId",
                table: "ProductCharacteristics",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCharacteristics_Products_ProductId",
                table: "ProductCharacteristics");

            migrationBuilder.DropTable(
                name: "ProductProductTag");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCharacteristics",
                table: "ProductCharacteristics");

            migrationBuilder.RenameTable(
                name: "ProductCharacteristics",
                newName: "Characteristics");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCharacteristics_ProductId",
                table: "Characteristics",
                newName: "IX_Characteristics_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characteristics",
                table: "Characteristics",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductFilters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFilters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductFilter",
                columns: table => new
                {
                    FiltersId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductFilter", x => new { x.FiltersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductProductFilter_ProductFilters_FiltersId",
                        column: x => x.FiltersId,
                        principalTable: "ProductFilters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductFilter_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductFilter_ProductsId",
                table: "ProductProductFilter",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Products_ProductId",
                table: "Characteristics",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
