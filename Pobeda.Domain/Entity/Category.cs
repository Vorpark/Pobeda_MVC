using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pobeda.Domain.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название категории")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Name { get; set; }

        [ValidateNever]
        public string TranslitName { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Display(Name = "Изображение")]
        public string ImageUrl { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
