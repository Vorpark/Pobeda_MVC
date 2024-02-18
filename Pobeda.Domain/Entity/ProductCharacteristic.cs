using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pobeda.Domain.Entity
{
    public class ProductCharacteristic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название характеристики")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Описание характеристики")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Description { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
