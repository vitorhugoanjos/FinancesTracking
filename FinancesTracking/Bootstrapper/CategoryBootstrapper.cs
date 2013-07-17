using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Bootstrapper
{
    public class CategoryBootstrapper
    {
        public CategoryBootstrapper()
        {
            Factory.GetFactory().GetCategoriesRepository().RegisterCategory(new Category("Lazer"));
            Factory.GetFactory().GetCategoriesRepository().RegisterCategory(new Category("Alimentacao"));
        }
    }
}
