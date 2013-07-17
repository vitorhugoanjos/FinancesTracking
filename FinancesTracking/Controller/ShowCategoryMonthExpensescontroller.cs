using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;
using FinancesTracking.Controller;

namespace FinancesTracking.Controller
{
    public class ShowCategoryMonthExpensescontroller
    {
        public List<Expense> GetMonthExpenses(int month, Category category)
        {
            List<Expense> expenses = GetCategoryExpenses(category);

            List<Expense> monthExpenses = new List<Expense>();

            foreach (Expense expense in expenses)
            {
                if (expense.Date.Month == month)
                    monthExpenses.Add(expense);
            }

            return monthExpenses;
        }

        private List<Expense> GetCategoryExpenses(Category category)
        {
            List<Expense> expenses = Factory.GetFactory().GetExpensesRepository().GetAllExpenses();
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
