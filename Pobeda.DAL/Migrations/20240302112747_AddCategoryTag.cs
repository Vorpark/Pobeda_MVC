using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTags_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryTags",
                columns: new[] { "Id", "CategoryId", "Href", "Name" },
                values: new object[,]
                {
                    { 1, 1, "#", "Iphone 15" },
                    { 2, 1, "#", "Iphone 13" },
                    { 3, 1, "#", "Samsung S22" },
                    { 4, 1, "#", "Samsung S21" },
                    { 5, 1, "/catalog/telefony/naushniki-dlya-telefonov/", "Наушники" },
                    { 6, 1, "#", "Power bank" },
                    { 7, 1, "#", "USB кабель" },
                    { 8, 1, "#", "Apple watch" },
                    { 9, 1, "#", "AirPods" },
                    { 10, 1, "#", "Iphone 11" },
                    { 11, 1, "#", "Iphone 14" },
                    { 12, 2, "#", "Macbook" },
                    { 13, 2, "#", "Acer" },
                    { 14, 2, "#", "Dell" },
                    { 15, 2, "#", "HP" },
                    { 16, 2, "catalog/kompyuternaya-tehnika/klaviatury/", "Клавиатуры" },
                    { 17, 2, "catalog/kompyuternaya-tehnika/jestkie-diski/", "Жесткий Диск" },
                    { 18, 2, "catalog/kompyuternaya-tehnika/printery-i-mfu/", "Принтер" },
                    { 19, 3, "#", "УШМ" },
                    { 20, 3, "#", "Дрель" },
                    { 21, 3, "#", "Шуруповерт" },
                    { 22, 3, "#", "Пила" },
                    { 23, 3, "#", "Нивелир" },
                    { 24, 3, "#", "Сварочник" },
                    { 25, 3, "#", "Фрезер" },
                    { 26, 3, "#", "Лобзик" },
                    { 27, 3, "#", "Набор инструментов" },
                    { 28, 4, "#", "PS1" },
                    { 29, 4, "#", "PS2" },
                    { 30, 4, "#", "PS3" },
                    { 31, 4, "#", "PS4" },
                    { 32, 4, "#", "PS5" },
                    { 33, 4, "#", "Джойстик" },
                    { 34, 5, "#", "Робот пылесос" },
                    { 35, 5, "#", "Отпариватель" },
                    { 36, 5, "#", "Обогреватель" },
                    { 37, 5, "#", "Электроплита" },
                    { 38, 5, "#", "Мясорубка" },
                    { 39, 5, "#", "Кофемолка" },
                    { 40, 5, "#", "Соковыжималка" },
                    { 41, 6, "#", "Сабвуфер" },
                    { 42, 6, "#", "Аптечка" },
                    { 43, 6, "#", "Домкрат" },
                    { 44, 6, "catalog/avto/radardetektory/", "Антирадар" },
                    { 45, 6, "#", "Компрессор" },
                    { 46, 6, "#", "Набор автомобилиста" },
                    { 47, 6, "#", "Сигнализация" },
                    { 48, 7, "#", "Штатив" },
                    { 49, 7, "#", "Вспышка" },
                    { 50, 7, "#", "Объектив" },
                    { 51, 8, "#", "Удочки" },
                    { 52, 8, "#", "Велосипед" },
                    { 53, 8, "#", "Гантели" },
                    { 54, 8, "#", "Бинокль" },
                    { 55, 8, "#", "Боксерские перчатки" },
                    { 56, 8, "#", "Шлемы" },
                    { 57, 8, "#", "Для сноуборда" },
                    { 58, 9, "#", "Tissot" },
                    { 59, 9, "#", "Куртка" },
                    { 60, 9, "#", "Джинсы" },
                    { 61, 9, "#", "Кроссовки" },
                    { 62, 9, "#", "Сувениры" },
                    { 63, 9, "#", "Шуба" },
                    { 64, 9, "#", "Коллекционные фигурки" },
                    { 65, 9, "#", "Футболки" },
                    { 66, 9, "#", "Casio" },
                    { 67, 10, "#", "Колонка JBL" },
                    { 68, 10, "#", "Ресивер" },
                    { 69, 10, "#", "Микрофон" },
                    { 70, 10, "catalog/audiotehnika/muzykalnye-centry/", "Музыкальный центр" },
                    { 71, 10, "#", "Яндекс станция" },
                    { 72, 10, "#", "Синтезатор" },
                    { 73, 10, "catalog/audiotehnika/domashnie-kinoteatry/", "Домашний кинотеатр" },
                    { 74, 11, "#", "Тв Samsung" },
                    { 75, 11, "#", "Тв Dexp" },
                    { 76, 11, "#", "Тв LG" },
                    { 77, 11, "#", "Кронштейн для ТВ" },
                    { 78, 11, "#", "Тв приставки" },
                    { 79, 11, "#", "Проекторы" },
                    { 80, 11, "#", "Провод HDMI" },
                    { 81, 12, "catalog/tovary-dlya-detei/detskie-avtokresla/", "Автокресла" },
                    { 82, 12, "#", "Самокат детский" },
                    { 83, 12, "#", "Велосипед детский" },
                    { 84, 12, "#", "Коляски" },
                    { 85, 12, "#", "Конструкторы" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTags_CategoryId",
                table: "CategoryTags",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryTags");
        }
    }
}
