using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public interface IFactory
    {
        IExpensesRepository GetExpensesRepository();
        IIncomesRepository GetIncomesRepository();
        ISavingsRepository GetSavingsRepository();
        ICategoriesRepository GetCategoriesRepository();
        IUsersRepository GetUsersRepository();
    }
}
