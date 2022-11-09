using System.Collections.Generic;

namespace MusicShop.DomainModel.EditCategory
{
    public interface IEditCategoryModel
    {
        List<Category> Categories { get; }

        Category Category { get; set; }

        void EditCategory(string name, int? idMainCategory);
    }
}
