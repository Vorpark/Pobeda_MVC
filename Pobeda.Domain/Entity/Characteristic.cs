using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pobeda.Domain.Entity
{
    public class Characteristic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название категории")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название продукта")]
        [MaxLength(30, ErrorMessage = "Поле не может превышать 30 символов")]
        public string Description { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
