using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pobeda.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название продукта")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Цена продукта")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Город")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string City { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Описание продукта")]
        [MaxLength(200, ErrorMessage = "Поле не может превышать 200 символов")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Изображение")]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Нужно выбрать категорию")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название подкатегории")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string SubCategory { get; set; } //Валидация соответствия подкатегории в рамках категории


        public ICollection<ProductCharacteristic> Characteristics {  get; set; }
        public ICollection<ProductFilter> Filters { get; set; }
    }
}
