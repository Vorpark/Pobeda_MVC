using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pobeda.Domain.Entity
{
    public class ProductTag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название фильтра")]
        [MaxLength(30, ErrorMessage = "Поле не может превышать 30 символов")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
