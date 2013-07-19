using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class RegisterExpenseController
    {

        public void CreateExpense(User user, string comment, decimal amount, Category category, DateTime date)
        {
            if (CanCreateExpense(user, amount))
            {
                Expense expense = new Expense(user, comment, amount, category, date);
                Factory.GetFactory().GetExpensesRepository().RegisterExpense(expense);
            }
        }

        public Boolean CanCreateExpense(User user, decimal amount)
        {
            return user.CanWidthraw(amount);
        }
    }
}
