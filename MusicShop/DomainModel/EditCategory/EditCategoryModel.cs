using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicShop.DomainModel.EditCategory
{
    public class EditCategoryModel : IEditCategoryModel
    {
        public Category Category { get; set; }

        public List<Category> Categories 
        { 
            get
            {
                var categories = Core.Context.Categories.OrderBy(c => c.Name).ToList();
                categories.Remove(Category);
                categories.Insert(0, new Category { IdCategory = -1, Name = "Отсутствует" });
                return categories;
            }
        }

        public EditCategoryModel(Category category)
        {
            Category = category;
        }

        public EditCategoryModel()
        {
            Category = new Category();
        }

        public void EditCategory(string name, int? idMainCategory)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Пожалуйста введите название категории.");
            }
            if (idMainCategory != null && Core.Context.Categories.Find(idMainCategory) == null)
            {
                throw new Exception("Пожалуйста выберите корректную главную категорию.");
            }
            Category.Name = name;
            Category.IdMainCategory = idMainCategory;
            if (Category.IdCategory == 0)
            {
                Core.Context.Categories.Add(Category);
            }
            Core.Context.SaveChanges();
        }
    }
}
