using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller;
using FinancesTracking.Model;

namespace FinancesTracking.View
{
    public class ShowExpensesUI
    {
        private ShowExpensesController controller = new ShowExpensesController();

        private void Header()
        {
            Console.WriteLine(" << SHOW ALL EXPENSES >> \n");
        }

        private void ShowExpensesList(List<Expense> expenses)
        {
            foreach (Expense expense in expenses)
                Console.WriteLine(expense);
        }
        
        public void Run()
        {
            Header();
            ShowExpensesList(controller.GetAllExpenses());
        }
    }
}
