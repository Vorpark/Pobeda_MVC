using Pobeda.Domain.Entity;
using Pobeda.Domain.Options;

namespace Pobeda.Domain.ViewModels
{
    public class CategoryVM
    {
        public string CategoryName { get; set; }
        public string TranslitCategoryName { get; set; }
        public string? SubCategoryName { get; set; }
        public string BannerImageUrl { get; set; }
        public IEnumerable<CategoryTag>? FilterItems { get; set; }
        public IEnumerable<Product>? Products { get; set; }
        public ICollection<CategoryCheckBoxOption> CheckBoxes { get; set; }
        public ICollection<string>? State {  get; set; }
    }
}
