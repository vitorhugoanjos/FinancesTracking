using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;
using FinancesTracking.Controller;

namespace FinancesTracking.View
{
    public class ShowMonthExpensesUI
    {

        private ShowMonthExpensescontroller controller = new ShowMonthExpensescontroller();

        private void Header()
        {
            Console.WriteLine(" << SHOW MONTH EXPENSES >> \n");
        }

        private void ShowExpensesList(List<Expense> expenses)
        {
            if (expenses.Count > 0)
                foreach (Expense expense in expenses)
                    Console.WriteLine(expense);
            else
                Console.WriteLine("There were no expenses registered in this month\n");
        }

        private int GetMonth()
        {
            int month;
            Console.WriteLine("Which month do you want to consult?");
            int.TryParse(Console.ReadLine(), out month);

            return month;
        }

        public void Run()
        {
            Header();

            List<Expense> expenses = controller.GetMonthExpenses(GetMonth());
            ShowExpensesList(expenses);

        }


    }
}
