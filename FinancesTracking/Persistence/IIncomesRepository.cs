using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public interface IIncomesRepository
    {
        void RegisterIncome(Model.Income income);
        void RemoveIncome(Model.Income income);
        List<Model.Income> GetAllIncomes();
        List<Model.Income> GetUserIncomes(Model.User user);
    }
}
