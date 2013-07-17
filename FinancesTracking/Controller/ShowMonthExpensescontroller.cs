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
    public class ShowMonthExpensescontroller
    {
        public List<Expense> GetMonthExpenses(int month)
        {
            List<Expense> expenses = Factory.GetFactory().GetExpensesRepository().GetAllExpenses();

            List<Expense> monthExpenses = new List<Expense>();

            foreach (Expense expense in expenses)
            {
                if (expense.Date.Month == month)
                    monthExpenses.Add(expense);
            }

            return monthExpenses;
        }
    }
}
