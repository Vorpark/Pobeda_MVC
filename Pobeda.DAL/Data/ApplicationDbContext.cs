using Microsoft.EntityFrameworkCore;
using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCharacteristic> ProductCharacteristics { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Телефоны", TranslitName = "telefony", ImageUrl = @"\img\category\category-telefony.png" },
                new Category { Id = 2, Name = "Компьютерная техника", TranslitName = "kompyuternaya-tehnika", ImageUrl = @"\img\category\category-kompyuternaya-tehnika.png" },
                new Category { Id = 3, Name = "Инструмент", TranslitName = "instrument", ImageUrl = @"\img\category\category-instrument.png" },
                new Category { Id = 4, Name = "Игры и приставки", TranslitName = "igry-i-pristavki", ImageUrl = @"\img\category\category-igry-i-pristavki.png" },
                new Category { Id = 5, Name = "Товары для дома", TranslitName = "tovary-dlya-doma", ImageUrl = @"\img\category\category-tovary-dlya-doma.png" },
                new Category { Id = 6, Name = "Авто", TranslitName = "avto", ImageUrl = @"\img\category\category-avto.png" },
                new Category { Id = 7, Name = "Фото и видеотехника", TranslitName = "foto-i-videotehnika", ImageUrl = @"\img\category\category-foto-i-videotehnika.png" },
                new Category { Id = 8, Name = "Хобби и отдых", TranslitName = "hobbi-i-otdyh", ImageUrl = @"\img\category\category-hobbi-i-otdyh.png" },
                new Category { Id = 9, Name = "Личные вещи", TranslitName = "lichnye-vecshi", ImageUrl = @"\img\category\category-lichnye-vecshi.png" },
                new Category { Id = 10, Name = "Аудиотехника", TranslitName = "audiotehnika", ImageUrl = @"\img\category\category-audiotehnika.png" },
                new Category { Id = 11, Name = "ТВ и видео", TranslitName = "tv-i-video", ImageUrl = @"\img\category\category-tv-i-video.png" },
                new Category { Id = 12, Name = "Товары для детей", TranslitName = "tovary-dlya-detei", ImageUrl = @"\img\category\category-tovary-dlya-detei.png" }
            );

            modelBuilder.Entity<SubCategory>().HasData( 
                new SubCategory { Id = 1, Name = "Сотовые телефоны", TranslitName = "sotovye-telefony", CategoryId = 1 },
                new SubCategory { Id = 2, Name = "Умные часы и браслеты", TranslitName = "umnye-chasy-i-braslety", CategoryId = 1 },
                new SubCategory { Id = 3, Name = "Наушники для телефонов", TranslitName = "naushniki-dlya-telefonov", CategoryId = 1 },
                new SubCategory { Id = 4, Name = "Рации", TranslitName = "racii", CategoryId = 1 },
                new SubCategory { Id = 5, Name = "Зарядные устройства", TranslitName = "zaryadnye-ustroistva", CategoryId = 1 },
                new SubCategory { Id = 6, Name = "Аксессуары для телефонов", TranslitName = "aksessuary-dlya-telefonov", CategoryId = 1 },

                new SubCategory { Id = 7, Name = "Ноутбуки", TranslitName = "noutbuki", CategoryId = 2 },
                new SubCategory { Id = 8, Name = "Системные блоки", TranslitName = "sistemnye-bloki", CategoryId = 2 },
                new SubCategory { Id = 9, Name = "Мониторы", TranslitName = "monitory", CategoryId = 2 },
                new SubCategory { Id = 10, Name = "Моноблоки", TranslitName = "monobloki", CategoryId = 2 },
                new SubCategory { Id = 11, Name = "Компьютерные мыши", TranslitName = "kompyuternye-myshi", CategoryId = 2 },
                new SubCategory { Id = 12, Name = "Клавиатуры", TranslitName = "klaviatury", CategoryId = 2 },
                new SubCategory { Id = 13, Name = "Компьютерные гарнитуры и наушники", TranslitName = "kompyuternye-garnitury-i-naushniki", CategoryId = 2 },
                new SubCategory { Id = 14, Name = "Web-камеры", TranslitName = "webkamery", CategoryId = 2 },
                new SubCategory { Id = 15, Name = "Планшетные пк", TranslitName = "planshetnye-pk", CategoryId = 2 },
                new SubCategory { Id = 16, Name = "Электронные книги", TranslitName = "elektronnye-knigi", CategoryId = 2 },
                new SubCategory { Id = 17, Name = "Принтеры и МФУ", TranslitName = "printery-i-mfu", CategoryId = 2 },
                new SubCategory { Id = 18, Name = "Роутеры и модемы", TranslitName = "routery-i-modemy", CategoryId = 2 },
                new SubCategory { Id = 19, Name = "Жесткие диски", TranslitName = "jestkie-diski", CategoryId = 2 },
                new SubCategory { Id = 20, Name = "Прочая оргтехника", TranslitName = "prochaya-orgtehnika", CategoryId = 2 },
                new SubCategory { Id = 21, Name = "Сетевые фильтры и удлинители", TranslitName = "setevye-filtry-i-udliniteli", CategoryId = 2 },
                new SubCategory { Id = 22, Name = "Аксессуары для компьютеров", TranslitName = "aksessuary-dlya-kompyuterov", CategoryId = 2 },

                new SubCategory { Id = 23, Name = "Аксессуары и расходные материалы", TranslitName = "aksessuary-i-rashodnye-materialy", CategoryId = 3 },
                new SubCategory { Id = 24, Name = "Измерительные инструменты", TranslitName = "izmeritelnye-instrumenty", CategoryId = 3 },
                new SubCategory { Id = 25, Name = "Спецодежда", TranslitName = "specodejda", CategoryId = 3 },
                new SubCategory { Id = 26, Name = "Электроинструмент", TranslitName = "elektroinstrument", CategoryId = 3 },
                new SubCategory { Id = 27, Name = "Ручной инструмент", TranslitName = "ruchnoi-instrument", CategoryId = 3 },
                new SubCategory { Id = 28, Name = "Сварочное оборудование", TranslitName = "svarochnoe-oborudovanie", CategoryId = 3 },
                new SubCategory { Id = 29, Name = "Бензоинструмент", TranslitName = "benzoinstrument", CategoryId = 3 },
                new SubCategory { Id = 30, Name = "Пневмоинструмент", TranslitName = "pnevmoinstrument", CategoryId = 3 },
                new SubCategory { Id = 31, Name = "Светотехника", TranslitName = "svetotehnika", CategoryId = 3 },
                new SubCategory { Id = 32, Name = "Техника для сада", TranslitName = "tehnika-dlya-sada", CategoryId = 3 },

                new SubCategory { Id = 33, Name = "Игровые приставки", TranslitName = "igrovye-pristavki", CategoryId = 4 },
                new SubCategory { Id = 34, Name = "Игры для приставок", TranslitName = "igry-dlya-pristavok", CategoryId = 4 },
                new SubCategory { Id = 35, Name = "Аксессуары для игровых приставок", TranslitName = "aksessuary-dlya-igrovyh-pristavok", CategoryId = 4 },
                new SubCategory { Id = 36, Name = "Настольные игры", TranslitName = "nastolnye-igry", CategoryId = 4 },

                new SubCategory { Id = 37, Name = "Хозяйственные товары", TranslitName = "hozyaistvennye-tovary", CategoryId = 5 },
                new SubCategory { Id = 38, Name = "Мультиварки", TranslitName = "multivarki", CategoryId = 5 },
                new SubCategory { Id = 39, Name = "Климатическое оборудование", TranslitName = "klimaticheskoe-oborudovanie", CategoryId = 5 },
                new SubCategory { Id = 40, Name = "Мебель и интерьер", TranslitName = "mebel-i-interer", CategoryId = 5 },
                new SubCategory { Id = 41, Name = "Микроволновые печи", TranslitName = "mikrovolnovye-pechi", CategoryId = 5 },
                new SubCategory { Id = 42, Name = "Пылесосы", TranslitName = "pylesosy", CategoryId = 5 },
                new SubCategory { Id = 43, Name = "Стиральные машины", TranslitName = "stiralnye-mashiny", CategoryId = 5 },
                new SubCategory { Id = 44, Name = "Товары для красоты и здоровья", TranslitName = "tovary-dlya-krasoty-i-zdorovya", CategoryId = 5 },
                new SubCategory { Id = 45, Name = "Товары для кухни", TranslitName = "tovary-dlya-kuhni", CategoryId = 5 },
                new SubCategory { Id = 46, Name = "Утюги и отпариватели", TranslitName = "utyugi-i-otparivateli", CategoryId = 5 },
                new SubCategory { Id = 47, Name = "Чайники и кофеварки", TranslitName = "chainiki-i-kofevarki", CategoryId = 5 },
                new SubCategory { Id = 48, Name = "Холодильники и морозильники", TranslitName = "holodilniki-i-morozilniki", CategoryId = 5 },
                new SubCategory { Id = 49, Name = "Швейные машины", TranslitName = "shveinye-mashiny", CategoryId = 5 },
                new SubCategory { Id = 50, Name = "Бритвы и машинки для стрижки", TranslitName = "britvy-i-mashinki-dlya-strijki", CategoryId = 5 },
                new SubCategory { Id = 51, Name = "Фены и плойки", TranslitName = "feny-i-ploiki", CategoryId = 5 },
                new SubCategory { Id = 52, Name = "Весы", TranslitName = "vesy", CategoryId = 5 },
                new SubCategory { Id = 53, Name = "Электрические плиты", TranslitName = "elektricheskie-plity", CategoryId = 5 },

                new SubCategory { Id = 54, Name = "Мойки высокого давления", TranslitName = "moiki-vysokogo-davleniya", CategoryId = 6 },
                new SubCategory { Id = 55, Name = "Насосы и компрессоры", TranslitName = "nasosy-i-kompressory", CategoryId = 6 },
                new SubCategory { Id = 56, Name = "Автомагнитолы", TranslitName = "avtomagnitoly", CategoryId = 6 },
                new SubCategory { Id = 57, Name = "Автомобильные аксессуары и комплектующие", TranslitName = "avtomobilnye-aksessuary-i-komplektuyucshie", CategoryId = 6 },
                new SubCategory { Id = 58, Name = "Автомобильные колонки", TranslitName = "avtomobilnye-kolonki", CategoryId = 6 },
                new SubCategory { Id = 59, Name = "Автомобильные сабвуферы", TranslitName = "avtomobilnye-sabvufery", CategoryId = 6 },
                new SubCategory { Id = 60, Name = "Автомобильные усилители", TranslitName = "avtomobilnye-usiliteli", CategoryId = 6 },
                new SubCategory { Id = 61, Name = "Парктроники и сигнализация", TranslitName = "parktroniki-i-signalizaciya", CategoryId = 6 },
                new SubCategory { Id = 62, Name = "Видеорегистраторы", TranslitName = "videoregistratory", CategoryId = 6 },
                new SubCategory { Id = 63, Name = "Навигаторы", TranslitName = "navigatory", CategoryId = 6 },
                new SubCategory { Id = 64, Name = "Шины и диски", TranslitName = "shiny-i-diski", CategoryId = 6 },

                new SubCategory { Id = 65, Name = "Фотоаппараты", TranslitName = "fotoapparaty", CategoryId = 7 },
                new SubCategory { Id = 66, Name = "Видеокамеры", TranslitName = "videokamery", CategoryId = 7 },
                new SubCategory { Id = 67, Name = "Аксессуары для фото и видеокамер", TranslitName = "aksessuary-dlya-foto-i-videokamer", CategoryId = 7 },

                new SubCategory { Id = 68, Name = "Зимний спортивный инвентарь", TranslitName = "zimnii-sportivnyi-inventar", CategoryId = 8 },
                new SubCategory { Id = 69, Name = "Металлоискатели", TranslitName = "metalloiskateli", CategoryId = 8 },
                new SubCategory { Id = 70, Name = "Бинокли и оптика", TranslitName = "binokli-i-optika", CategoryId = 8 },
                new SubCategory { Id = 71, Name = "Водный инвентарь", TranslitName = "vodnyi-inventar", CategoryId = 8 },
                new SubCategory { Id = 72, Name = "Тату-машинки", TranslitName = "tatumashinki", CategoryId = 8 },
                new SubCategory { Id = 73, Name = "Велосипеды и самокаты", TranslitName = "velosipedy-i-samokaty", CategoryId = 8 },
                new SubCategory { Id = 74, Name = "Пневматика и электрошокеры", TranslitName = "pnevmatika-i-elektroshokery", CategoryId = 8 },
                new SubCategory { Id = 75, Name = "Тренажеры", TranslitName = "trenajery", CategoryId = 8 },
                new SubCategory { Id = 76, Name = "Роликовые и ледовые коньки", TranslitName = "rolikovye-i-ledovye-konki", CategoryId = 8 },
                new SubCategory { Id = 77, Name = "Туризм", TranslitName = "turizm", CategoryId = 8 },

                new SubCategory { Id = 78, Name = "Канцтовары", TranslitName = "kanctovary", CategoryId = 9 },
                new SubCategory { Id = 79, Name = "Часы", TranslitName = "chasy", CategoryId = 9 },
                new SubCategory { Id = 80, Name = "Кошельки и сумки", TranslitName = "koshelki-i-sumki", CategoryId = 9 },

                new SubCategory { Id = 81, Name = "Музыкальные инструменты", TranslitName = "muzykalnye-instrumenty", CategoryId = 10 },
                new SubCategory { Id = 82, Name = "MP3 плееры", TranslitName = "mp3-pleery", CategoryId = 10 },
                new SubCategory { Id = 83, Name = "Колонки", TranslitName = "kolonki", CategoryId = 10 },
                new SubCategory { Id = 84, Name = "Домашние кинотеатры", TranslitName = "domashnie-kinoteatry", CategoryId = 10 },
                new SubCategory { Id = 85, Name = "Музыкальные центры", TranslitName = "muzykalnye-centry", CategoryId = 10 },

                new SubCategory { Id = 86, Name = "Телевизоры", TranslitName = "televizory", CategoryId = 11 },
                new SubCategory { Id = 87, Name = "Видео", TranslitName = "video", CategoryId = 11 },
                new SubCategory { Id = 88, Name = "Проекторы", TranslitName = "proektory", CategoryId = 11 },
                new SubCategory { Id = 89, Name = "Цифровое телевидение", TranslitName = "cifrovoe-televidenie", CategoryId = 11 },
                new SubCategory { Id = 90, Name = "Аксессуары для ТВ и видео", TranslitName = "aksessuary-dlya-tv-i-video", CategoryId = 11 },

                new SubCategory { Id = 91, Name = "Детские автокресла", TranslitName = "detskie-avtokresla", CategoryId = 12 },
                new SubCategory { Id = 92, Name = "Детские игрушки", TranslitName = "detskie-igrushki", CategoryId = 12 }
            );

            modelBuilder.Entity<ProductTag>().HasData(
                new ProductTag { Id = 1, Name = "В кредит"},
                new ProductTag { Id = 2, Name = "Состояние новый" },
                new ProductTag { Id = 3, Name = "Состояние хорошее" },
                new ProductTag { Id = 4, Name = "Состояние отличное" },
                new ProductTag { Id = 5, Name = "Состояние удовлетворительное" }
            );

            var productCharacteristic1 = new ProductCharacteristic { Id = 1, };

            modelBuilder.Entity<ProductCharacteristic>().HasData(
            new ProductCharacteristic
            {
                Id = 1,
                Key = "Объем оперативной памяти",
                Value = "32 ГБ",
                ProductId = 1
            },
            new ProductCharacteristic
            {
                Id = 2,
                Key = "Тактовая частота процессора",
                Value = "2600 МГц",
                ProductId = 1
            },
            new ProductCharacteristic
            {
                Id = 3,
                Key = "Количество ядер процессора",
                Value = "6",
                ProductId = 1
            },
            new ProductCharacteristic
            {
                Id = 4,
                Key = "Тип оперативной памяти",
                Value = "DDR4",
                ProductId = 1
            },

            new ProductCharacteristic
            {
                Id = 5,
                Key = "Диагональ",
                Value = "4 дюйм.",
                ProductId = 2
            },
            new ProductCharacteristic
            {
                Id = 6,
                Key = "Объем встроенной памяти",
                Value = "128 ГБ",
                ProductId = 2
            },
            new ProductCharacteristic
            {
                Id = 7,
                Key = "Объем оперативной памяти",
                Value = "2 ГБ",
                ProductId = 2
            },
            new ProductCharacteristic
            {
                Id = 8,
                Key = "Количество ядер процессора",
                Value = "2",
                ProductId = 2
            }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Системный блок",
                TranslitName = "sistemnyj-blok",
                Price = 59000,
                City = "Самара",
                Description = "Состояние хорошее.",
                ImageUrl = @"\products_image\product_photo_1.webp",
                CategoryId = 2,
                SubCategoryId = 8
            },
            new Product
            {
                Id = 2,
                Name = "Apple iPhone SE 128GB",
                TranslitName = "apple-iphone-se-128gb",
                Price = 11900,
                City = "Саратов",
                Description = "Состояние хорошее.",
                ImageUrl = @"\products_image\product_photo_2.webp",
                CategoryId = 1,
                SubCategoryId = 1
            }
            );

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductProductTag",
                    r => r.HasOne<ProductTag>().WithMany().HasForeignKey("TagsId"),
                    l => l.HasOne<Product>().WithMany().HasForeignKey("ProductsId"),
                    je =>
                    {
                        je.HasKey("ProductsId", "TagsId");
                        je.HasData(
                            new { ProductsId = 1, TagsId = 3 },
                            new { ProductsId = 2, TagsId = 1 },
                            new { ProductsId = 2, TagsId = 3 });
                    });
        }
    }
}
