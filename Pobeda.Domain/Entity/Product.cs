using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pobeda.Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название продукта")]
        [MaxLength(30, ErrorMessage = "Поле не может превышать 30 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Цена продукта")]
        public double Cost { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название продукта")]
        [MaxLength(200, ErrorMessage = "Поле не может превышать 200 символов")]
        public string Description { get; set; }

        public List<Characteristic> Characteristics {  get; set; } 
    }
}
