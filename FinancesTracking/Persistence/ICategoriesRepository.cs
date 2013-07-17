using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public interface ICategoriesRepository
    {
        void RegisterCategory(Model.Category category);
        void RemoveCategory(Model.Category category);
        Model.Category GetCategory(string name);
        List<Model.Category> GetAllCategories();
    }
}
