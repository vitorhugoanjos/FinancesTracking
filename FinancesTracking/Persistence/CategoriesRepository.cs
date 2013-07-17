using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public class CategoriesRepository:ICategoriesRepository
    {
        private static CategoriesRepository repository = null;

        private List<Model.Category> categories;

        private CategoriesRepository()
        {
            categories = new List<Model.Category>();
        }

        public static CategoriesRepository GetRepository()
        {
            return repository == null ? (repository = new CategoriesRepository()) : repository;
        }

        public void RegisterCategory(Model.Category category)
        {
            categories.Add(category);
        }

        public void RemoveCategory(Model.Category category)
        {
            throw new NotImplementedException();
        }

        public Model.Category GetCategory(string name)
        { 
            foreach(Model.Category category in categories)
            {
                if (category.Name.Equals(name))
                    return category;
            }

            return null;
        }

        public List<Model.Category> GetAllCategories()
        {
            return categories;
        }
    }
}
