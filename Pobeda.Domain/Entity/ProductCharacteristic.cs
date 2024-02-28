using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pobeda.Domain.Entity
{
    public class ProductCharacteristic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название характеристики")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Key { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Описание характеристики")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Value { get; set; }

        [Required]
        public int ProductId { get; set; }
    }
}
