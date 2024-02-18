using Microsoft.EntityFrameworkCore;
using Pobeda.Domain.Entity;

namespace Pobeda.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCharacteristic> Characteristics { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProductFilter> ProductFilters { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Телефоны" },
                new Category { Id = 2, Name = "Компьютерная техника" },
                new Category { Id = 3, Name = "Инструмент" },
                new Category { Id = 4, Name = "Игры и приставки" },
                new Category { Id = 5, Name = "Товары для дома" },
                new Category { Id = 6, Name = "Авто" },
                new Category { Id = 7, Name = "Фото и видеотехника" },
                new Category { Id = 8, Name = "Хобби и отдых" },
                new Category { Id = 9, Name = "Личные вещи" },
                new Category { Id = 10, Name = "Аудиотехника" },
                new Category { Id = 11, Name = "ТВ и видео" },
                new Category { Id = 12, Name = "Товары для детей" }
            );

            modelBuilder.Entity<SubCategory>().HasData( 
                new SubCategory { Id = 1, Name = "Сотовые телефоны", CategoryId = 1 },
                new SubCategory { Id = 2, Name = "Умные часы и браслеты", CategoryId = 1 },
                new SubCategory { Id = 3, Name = "Наушники для телефонов", CategoryId = 1 },
                new SubCategory { Id = 4, Name = "Рации", CategoryId = 1 },
                new SubCategory { Id = 5, Name = "Зарядные устройства", CategoryId = 1 },
                new SubCategory { Id = 6, Name = "Аксессуары для телефонов", CategoryId = 1 },

                new SubCategory { Id = 7, Name = "Ноутбуки", CategoryId = 2 },
                new SubCategory { Id = 8, Name = "Системные блоки", CategoryId = 2 },
                new SubCategory { Id = 9, Name = "Мониторы", CategoryId = 2 },
                new SubCategory { Id = 10, Name = "Моноблоки", CategoryId = 2 },
                new SubCategory { Id = 11, Name = "Компьютерные мыши", CategoryId = 2 },
                new SubCategory { Id = 12, Name = "Клавиатуры", CategoryId = 2 },
                new SubCategory { Id = 13, Name = "Компьютерные гарнитуры и наушники", CategoryId = 2 },
                new SubCategory { Id = 14, Name = "Web-камеры", CategoryId = 2 },
                new SubCategory { Id = 15, Name = "Планшетные пк", CategoryId = 2 },
                new SubCategory { Id = 16, Name = "Электронные книги", CategoryId = 2 },
                new SubCategory { Id = 17, Name = "Принтеры и МФУ", CategoryId = 2 },
                new SubCategory { Id = 18, Name = "Роутеры и модемы", CategoryId = 2 },
                new SubCategory { Id = 19, Name = "Жесткие диски", CategoryId = 2 },
                new SubCategory { Id = 20, Name = "Прочая оргтехника", CategoryId = 2 },
                new SubCategory { Id = 21, Name = "Сетевые фильтры и удлинители", CategoryId = 2 },
                new SubCategory { Id = 22, Name = "Аксессуары для компьютеров", CategoryId = 2 },

                new SubCategory { Id = 23, Name = "Аксессуары и расходные материалы", CategoryId = 3 },
                new SubCategory { Id = 24, Name = "Измерительные инструменты", CategoryId = 3 },
                new SubCategory { Id = 25, Name = "Спецодежда", CategoryId = 3 },
                new SubCategory { Id = 26, Name = "Электроинструмент", CategoryId = 3 },
                new SubCategory { Id = 27, Name = "Ручной инструмент", CategoryId = 3 },
                new SubCategory { Id = 28, Name = "Сварочное оборудование", CategoryId = 3 },
                new SubCategory { Id = 29, Name = "Бензоинструмент", CategoryId = 3 },
                new SubCategory { Id = 30, Name = "Пневмоинструмент", CategoryId = 3 },
                new SubCategory { Id = 31, Name = "Светотехника", CategoryId = 3 },
                new SubCategory { Id = 32, Name = "Техника для сада", CategoryId = 3 },

                new SubCategory { Id = 33, Name = "Игровые приставки", CategoryId = 4 },
                new SubCategory { Id = 34, Name = "Игры для приставок", CategoryId = 4 },
                new SubCategory { Id = 35, Name = "Аксессуары для игровых приставок", CategoryId = 4 },
                new SubCategory { Id = 36, Name = "Настольные игры", CategoryId = 4 },

                new SubCategory { Id = 37, Name = "Хозяйственные товары", CategoryId = 5 },
                new SubCategory { Id = 38, Name = "Мультиварки", CategoryId = 5 },
                new SubCategory { Id = 39, Name = "Климатическое оборудование", CategoryId = 5 },
                new SubCategory { Id = 40, Name = "Мебель и интерьер", CategoryId = 5 },
                new SubCategory { Id = 41, Name = "Микроволновые печи", CategoryId = 5 },
                new SubCategory { Id = 42, Name = "Пылесосы", CategoryId = 5 },
                new SubCategory { Id = 43, Name = "Стиральные машины", CategoryId = 5 },
                new SubCategory { Id = 44, Name = "Товары для красоты и здоровья", CategoryId = 5 },
                new SubCategory { Id = 45, Name = "Товары для кухни", CategoryId = 5 },
                new SubCategory { Id = 46, Name = "Утюги и отпариватели", CategoryId = 5 },
                new SubCategory { Id = 47, Name = "Чайники и кофеварки", CategoryId = 5 },
                new SubCategory { Id = 48, Name = "Холодильники и морозильники", CategoryId = 5 },
                new SubCategory { Id = 49, Name = "Швейные машины", CategoryId = 5 },
                new SubCategory { Id = 50, Name = "Бритвы и машинки для стрижки", CategoryId = 5 },
                new SubCategory { Id = 51, Name = "Фены и плойки", CategoryId = 5 },
                new SubCategory { Id = 52, Name = "Весы", CategoryId = 5 },
                new SubCategory { Id = 53, Name = "Электрические плиты", CategoryId = 5 },

                new SubCategory { Id = 54, Name = "Мойки высокого давления", CategoryId = 6 },
                new SubCategory { Id = 55, Name = "Насосы и компрессоры", CategoryId = 6 },
                new SubCategory { Id = 56, Name = "Автомагнитолы", CategoryId = 6 },
                new SubCategory { Id = 57, Name = "Автомобильные аксессуары и комплектующие", CategoryId = 6 },
                new SubCategory { Id = 58, Name = "Автомобильные колонки", CategoryId = 6 },
                new SubCategory { Id = 59, Name = "Автомобильные сабвуферы", CategoryId = 6 },
                new SubCategory { Id = 60, Name = "Автомобильные усилители", CategoryId = 6 },
                new SubCategory { Id = 61, Name = "Парктроники и сигнализация", CategoryId = 6 },
                new SubCategory { Id = 62, Name = "Видеорегистраторы", CategoryId = 6 },
                new SubCategory { Id = 63, Name = "Навигаторы", CategoryId = 6 },
                new SubCategory { Id = 64, Name = "Шины и диски", CategoryId = 6 },

                new SubCategory { Id = 65, Name = "Фотоаппараты", CategoryId = 7 },
                new SubCategory { Id = 66, Name = "Видеокамеры", CategoryId = 7 },
                new SubCategory { Id = 67, Name = "Аксессуары для фото и видеокамер", CategoryId = 7 },

                new SubCategory { Id = 68, Name = "Зимний спортивный инвентарь", CategoryId = 8 },
                new SubCategory { Id = 69, Name = "Металлоискатели", CategoryId = 8 },
                new SubCategory { Id = 70, Name = "Бинокли и оптика", CategoryId = 8 },
                new SubCategory { Id = 71, Name = "Водный инвентарь", CategoryId = 8 },
                new SubCategory { Id = 72, Name = "Тату-машинки", CategoryId = 8 },
                new SubCategory { Id = 73, Name = "Велосипеды и самокаты", CategoryId = 8 },
                new SubCategory { Id = 74, Name = "Пневматика и электрошокеры", CategoryId = 8 },
                new SubCategory { Id = 75, Name = "Тренажеры", CategoryId = 8 },
                new SubCategory { Id = 76, Name = "Роликовые и ледовые коньки", CategoryId = 8 },
                new SubCategory { Id = 77, Name = "Туризм", CategoryId = 8 },

                new SubCategory { Id = 78, Name = "Канцтовары", CategoryId = 9 },
                new SubCategory { Id = 79, Name = "Часы", CategoryId = 9 },
                new SubCategory { Id = 80, Name = "Кошельки и сумки", CategoryId = 9 },

                new SubCategory { Id = 81, Name = "Музыкальные инструменты", CategoryId = 10 },
                new SubCategory { Id = 82, Name = "MP3 плееры", CategoryId = 10 },
                new SubCategory { Id = 83, Name = "Колонки", CategoryId = 10 },
                new SubCategory { Id = 84, Name = "Домашние кинотеатры", CategoryId = 10 },
                new SubCategory { Id = 85, Name = "Музыкальные центры", CategoryId = 10 },

                new SubCategory { Id = 86, Name = "Телевизоры", CategoryId = 11 },
                new SubCategory { Id = 87, Name = "Видео", CategoryId = 11 },
                new SubCategory { Id = 88, Name = "Проекторы", CategoryId = 11 },
                new SubCategory { Id = 89, Name = "Цифровое телевидение", CategoryId = 11 },
                new SubCategory { Id = 90, Name = "Аксессуары для ТВ и видео", CategoryId = 11 },

                new SubCategory { Id = 91, Name = "Детские автокресла", CategoryId = 12 },
                new SubCategory { Id = 92, Name = "Детские игрушки", CategoryId = 12 }
            );
        }
    }
}
