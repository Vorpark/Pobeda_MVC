using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pobeda.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAllAndInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TranslitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TranslitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TranslitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartProduct",
                columns: table => new
                {
                    CartsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProduct", x => new { x.CartsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CartProduct_Carts_CartsId",
                        column: x => x.CartsId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCharacteristics_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Carts",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name", "TranslitName" },
                values: new object[,]
                {
                    { 1, "\\img\\category\\category-telefony.png", "Телефоны", "telefony" },
                    { 2, "\\img\\category\\category-kompyuternaya-tehnika.png", "Компьютерная техника", "kompyuternaya-tehnika" },
                    { 3, "\\img\\category\\category-instrument.png", "Инструмент", "instrument" },
                    { 4, "\\img\\category\\category-igry-i-pristavki.png", "Игры и приставки", "igry-i-pristavki" },
                    { 5, "\\img\\category\\category-tovary-dlya-doma.png", "Товары для дома", "tovary-dlya-doma" },
                    { 6, "\\img\\category\\category-avto.png", "Авто", "avto" },
                    { 7, "\\img\\category\\category-foto-i-videotehnika.png", "Фото и видеотехника", "foto-i-videotehnika" },
                    { 8, "\\img\\category\\category-hobbi-i-otdyh.png", "Хобби и отдых", "hobbi-i-otdyh" },
                    { 9, "\\img\\category\\category-lichnye-vecshi.png", "Личные вещи", "lichnye-vecshi" },
                    { 10, "\\img\\category\\category-audiotehnika.png", "Аудиотехника", "audiotehnika" },
                    { 11, "\\img\\category\\category-tv-i-video.png", "ТВ и видео", "tv-i-video" },
                    { 12, "\\img\\category\\category-tovary-dlya-detei.png", "Товары для детей", "tovary-dlya-detei" }
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
                    { 16, 2, "/catalog/kompyuternaya-tehnika/klaviatury/", "Клавиатуры" },
                    { 17, 2, "/catalog/kompyuternaya-tehnika/jestkie-diski/", "Жесткий Диск" },
                    { 18, 2, "/catalog/kompyuternaya-tehnika/printery-i-mfu/", "Принтер" },
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
                    { 44, 6, "/catalog/avto/radardetektory/", "Антирадар" },
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
                    { 70, 10, "/catalog/audiotehnika/muzykalnye-centry/", "Музыкальный центр" },
                    { 71, 10, "#", "Яндекс станция" },
                    { 72, 10, "#", "Синтезатор" },
                    { 73, 10, "/catalog/audiotehnika/domashnie-kinoteatry/", "Домашний кинотеатр" },
                    { 74, 11, "#", "Тв Samsung" },
                    { 75, 11, "#", "Тв Dexp" },
                    { 76, 11, "#", "Тв LG" },
                    { 77, 11, "#", "Кронштейн для ТВ" },
                    { 78, 11, "#", "Тв приставки" },
                    { 79, 11, "#", "Проекторы" },
                    { 80, 11, "#", "Провод HDMI" },
                    { 81, 12, "/catalog/tovary-dlya-detei/detskie-avtokresla/", "Автокресла" },
                    { 82, 12, "#", "Самокат детский" },
                    { 83, 12, "#", "Велосипед детский" },
                    { 84, 12, "#", "Коляски" },
                    { 85, 12, "#", "Конструкторы" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name", "TranslitName" },
                values: new object[,]
                {
                    { 1, 1, "Сотовые телефоны", "sotovye-telefony" },
                    { 2, 1, "Умные часы и браслеты", "umnye-chasy-i-braslety" },
                    { 3, 1, "Наушники для телефонов", "naushniki-dlya-telefonov" },
                    { 4, 1, "Рации", "racii" },
                    { 5, 1, "Зарядные устройства", "zaryadnye-ustroistva" },
                    { 6, 1, "Аксессуары для телефонов", "aksessuary-dlya-telefonov" },
                    { 7, 2, "Ноутбуки", "noutbuki" },
                    { 8, 2, "Системные блоки", "sistemnye-bloki" },
                    { 9, 2, "Мониторы", "monitory" },
                    { 10, 2, "Моноблоки", "monobloki" },
                    { 11, 2, "Компьютерные мыши", "kompyuternye-myshi" },
                    { 12, 2, "Клавиатуры", "klaviatury" },
                    { 13, 2, "Компьютерные гарнитуры и наушники", "kompyuternye-garnitury-i-naushniki" },
                    { 14, 2, "Web-камеры", "webkamery" },
                    { 15, 2, "Планшетные пк", "planshetnye-pk" },
                    { 16, 2, "Электронные книги", "elektronnye-knigi" },
                    { 17, 2, "Принтеры и МФУ", "printery-i-mfu" },
                    { 18, 2, "Роутеры и модемы", "routery-i-modemy" },
                    { 19, 2, "Жесткие диски", "jestkie-diski" },
                    { 20, 2, "Прочая оргтехника", "prochaya-orgtehnika" },
                    { 21, 2, "Сетевые фильтры и удлинители", "setevye-filtry-i-udliniteli" },
                    { 22, 2, "Аксессуары для компьютеров", "aksessuary-dlya-kompyuterov" },
                    { 23, 3, "Аксессуары и расходные материалы", "aksessuary-i-rashodnye-materialy" },
                    { 24, 3, "Измерительные инструменты", "izmeritelnye-instrumenty" },
                    { 25, 3, "Спецодежда", "specodejda" },
                    { 26, 3, "Электроинструмент", "elektroinstrument" },
                    { 27, 3, "Ручной инструмент", "ruchnoi-instrument" },
                    { 28, 3, "Сварочное оборудование", "svarochnoe-oborudovanie" },
                    { 29, 3, "Бензоинструмент", "benzoinstrument" },
                    { 30, 3, "Пневмоинструмент", "pnevmoinstrument" },
                    { 31, 3, "Светотехника", "svetotehnika" },
                    { 32, 3, "Техника для сада", "tehnika-dlya-sada" },
                    { 33, 4, "Игровые приставки", "igrovye-pristavki" },
                    { 34, 4, "Игры для приставок", "igry-dlya-pristavok" },
                    { 35, 4, "Аксессуары для игровых приставок", "aksessuary-dlya-igrovyh-pristavok" },
                    { 36, 4, "Настольные игры", "nastolnye-igry" },
                    { 37, 5, "Хозяйственные товары", "hozyaistvennye-tovary" },
                    { 38, 5, "Мультиварки", "multivarki" },
                    { 39, 5, "Климатическое оборудование", "klimaticheskoe-oborudovanie" },
                    { 40, 5, "Мебель и интерьер", "mebel-i-interer" },
                    { 41, 5, "Микроволновые печи", "mikrovolnovye-pechi" },
                    { 42, 5, "Пылесосы", "pylesosy" },
                    { 43, 5, "Стиральные машины", "stiralnye-mashiny" },
                    { 44, 5, "Товары для красоты и здоровья", "tovary-dlya-krasoty-i-zdorovya" },
                    { 45, 5, "Товары для кухни", "tovary-dlya-kuhni" },
                    { 46, 5, "Утюги и отпариватели", "utyugi-i-otparivateli" },
                    { 47, 5, "Чайники и кофеварки", "chainiki-i-kofevarki" },
                    { 48, 5, "Холодильники и морозильники", "holodilniki-i-morozilniki" },
                    { 49, 5, "Швейные машины", "shveinye-mashiny" },
                    { 50, 5, "Бритвы и машинки для стрижки", "britvy-i-mashinki-dlya-strijki" },
                    { 51, 5, "Фены и плойки", "feny-i-ploiki" },
                    { 52, 5, "Весы", "vesy" },
                    { 53, 5, "Электрические плиты", "elektricheskie-plity" },
                    { 54, 6, "Мойки высокого давления", "moiki-vysokogo-davleniya" },
                    { 55, 6, "Насосы и компрессоры", "nasosy-i-kompressory" },
                    { 56, 6, "Автомагнитолы", "avtomagnitoly" },
                    { 57, 6, "Автомобильные аксессуары и комплектующие", "avtomobilnye-aksessuary-i-komplektuyucshie" },
                    { 58, 6, "Автомобильные колонки", "avtomobilnye-kolonki" },
                    { 59, 6, "Автомобильные сабвуферы", "avtomobilnye-sabvufery" },
                    { 60, 6, "Автомобильные усилители", "avtomobilnye-usiliteli" },
                    { 61, 6, "Парктроники и сигнализация", "parktroniki-i-signalizaciya" },
                    { 62, 6, "Видеорегистраторы", "videoregistratory" },
                    { 63, 6, "Навигаторы", "navigatory" },
                    { 64, 6, "Шины и диски", "shiny-i-diski" },
                    { 65, 7, "Фотоаппараты", "fotoapparaty" },
                    { 66, 7, "Видеокамеры", "videokamery" },
                    { 67, 7, "Аксессуары для фото и видеокамер", "aksessuary-dlya-foto-i-videokamer" },
                    { 68, 8, "Зимний спортивный инвентарь", "zimnii-sportivnyi-inventar" },
                    { 69, 8, "Металлоискатели", "metalloiskateli" },
                    { 70, 8, "Бинокли и оптика", "binokli-i-optika" },
                    { 71, 8, "Водный инвентарь", "vodnyi-inventar" },
                    { 72, 8, "Тату-машинки", "tatumashinki" },
                    { 73, 8, "Велосипеды и самокаты", "velosipedy-i-samokaty" },
                    { 74, 8, "Пневматика и электрошокеры", "pnevmatika-i-elektroshokery" },
                    { 75, 8, "Тренажеры", "trenajery" },
                    { 76, 8, "Роликовые и ледовые коньки", "rolikovye-i-ledovye-konki" },
                    { 77, 8, "Туризм", "turizm" },
                    { 78, 9, "Канцтовары", "kanctovary" },
                    { 79, 9, "Часы", "chasy" },
                    { 80, 9, "Кошельки и сумки", "koshelki-i-sumki" },
                    { 81, 10, "Музыкальные инструменты", "muzykalnye-instrumenty" },
                    { 82, 10, "MP3 плееры", "mp3-pleery" },
                    { 83, 10, "Колонки", "kolonki" },
                    { 84, 10, "Домашние кинотеатры", "domashnie-kinoteatry" },
                    { 85, 10, "Музыкальные центры", "muzykalnye-centry" },
                    { 86, 11, "Телевизоры", "televizory" },
                    { 87, 11, "Видео", "video" },
                    { 88, 11, "Проекторы", "proektory" },
                    { 89, 11, "Цифровое телевидение", "cifrovoe-televidenie" },
                    { 90, 11, "Аксессуары для ТВ и видео", "aksessuary-dlya-tv-i-video" },
                    { 91, 12, "Детские автокресла", "detskie-avtokresla" },
                    { 92, 12, "Детские игрушки", "detskie-igrushki" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "City", "Description", "ImageUrl", "Name", "Price", "SubCategoryId", "TranslitName" },
                values: new object[,]
                {
                    { 1, 2, "Самара", "Состояние хорошее.", "\\products_image\\product_photo_1.webp", "Системный блок", 59000.0, 8, "sistemnyj-blok" },
                    { 2, 1, "Саратов", "Состояние хорошее.", "\\products_image\\product_photo_2.webp", "Apple iPhone SE 128GB", 11900.0, 1, "apple-iphone-se-128gb" },
                    { 3, 1, "Самара", "Состояние отличное.", "\\products_image\\product_photo_3.webp", "Apple iPhone 11 64GB", 29900.0, 1, "apple-iphone-11-64gb" },
                    { 4, 1, "Саратов", "Состояние новый.", "\\products_image\\product_photo_4.webp", "Apple iPhone 12 128GB", 49900.0, 1, "apple-iphone-12-128gb" }
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
                    { 8, "Количество ядер процессора", 2, "2" },
                    { 9, "Диагональ", 3, "6.1 дюйм." },
                    { 10, "Объем встроенной памяти", 3, "64 ГБ" },
                    { 11, "Объем оперативной памяти", 3, "4 ГБ" },
                    { 12, "Количество ядер процессора", 3, "6" },
                    { 13, "Диагональ", 4, "6.1 дюйм." },
                    { 14, "Объем встроенной памяти", 4, "128 ГБ" },
                    { 15, "Объем оперативной памяти", 4, "4 ГБ" },
                    { 16, "Количество ядер процессора", 4, "6" }
                });

            migrationBuilder.InsertData(
                table: "ProductProductTag",
                columns: new[] { "ProductsId", "TagsId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartProduct_ProductsId",
                table: "CartProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTags_CategoryId",
                table: "CategoryTags",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCharacteristics_ProductId",
                table: "ProductCharacteristics",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductTag_TagsId",
                table: "ProductProductTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProduct");

            migrationBuilder.DropTable(
                name: "CategoryTags");

            migrationBuilder.DropTable(
                name: "ProductCharacteristics");

            migrationBuilder.DropTable(
                name: "ProductProductTag");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
