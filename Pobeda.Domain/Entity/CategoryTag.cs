using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pobeda.Domain.Entity
{
    public class CategoryTag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название тега")]
        [MaxLength(30, ErrorMessage = "Поле не может превышать 30 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string Href { get; set; }

        [Required(ErrorMessage = "Нужно выбрать категорию")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
    }
}
