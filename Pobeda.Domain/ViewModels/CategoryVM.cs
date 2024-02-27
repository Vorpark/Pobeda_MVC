﻿using Pobeda.Domain.Entity;

namespace Pobeda.Domain.ViewModels
{
    public class CategoryVM
    {
        public string CategoryName { get; set; }
        public string TranslitCategoryName { get; set; }
        public string? SubCategoryName { get; set; }
        public string? TranslitSubCategoryName { get; set; }
        public string BannerImageUrl { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
