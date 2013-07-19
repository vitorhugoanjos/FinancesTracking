using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class RegisterIncomeController
    {
        public void CreateIncome(User user, decimal amount, string description) 
        {
            Income income = new Income(user, amount, description);
            Factory.GetFactory().GetIncomesRepository().RegisterIncome(income);
        }
    }
}
