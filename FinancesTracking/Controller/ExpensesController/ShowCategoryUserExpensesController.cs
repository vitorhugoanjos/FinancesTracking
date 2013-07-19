using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class ShowCategoryUserExpensesController
    {
        public List<Expense> GetCategoryExpenses(Category category, User user)
        {
            List<Expense> expenses = Factory.GetFactory().GetExpensesRepository().GetUserExpenses(user);
            List<Expense> filtered = new List<Expense>();

            if (expenses.Count > 0)
            {
                foreach (Expense expense in expenses)
                {
                    if (expense.Category.Name.Equals(category.Name))
                        filtered.Add(expense);
                }
            }

            return filtered;
        }

        
    }
}
