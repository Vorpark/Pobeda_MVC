﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Pobeda.Domain.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название категории")]
        [MaxLength(50, ErrorMessage = "Поле не может превышать 50 символов")]
        public string Name { get; set; }

        public List<SubCategory> SubCategories { get; set; }
        public List<Product> Products { get; set; }
    }
}