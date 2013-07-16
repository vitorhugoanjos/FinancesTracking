using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public class ExpenseRepository:IExpensesRepository
    {

        private static ExpenseRepository repository = null;

        private List<Model.Expense> expenses;

        private ExpenseRepository()
        {
            expenses = new List<Model.Expense>();
        }

        public static ExpenseRepository GetRepository()
        {
            return repository == null ? (repository = new ExpenseRepository()) : repository;
        }

        public void RegisterExpense(Model.Expense expense)
        {
            expenses.Add(expense);
        }

        public void RemoveExpense(Model.Expense expense)
        {
            throw new NotImplementedException();
        }

        public List<Model.Expense> GetAllExpenses()
        {
            return expenses;
        }
    }
}
