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
    public class ShowUsersExpensesUI
    {
        private ShowUsersExpensesController controller = new ShowUsersExpensesController();

        private User GetUser()
        {
            Console.WriteLine("Choose an  user: ");

            foreach (User _user in Factory.GetFactory().GetUsersRepository().GetUsers())
            {
                Console.WriteLine(_user.Name);
            }

            string name = Console.ReadLine();

            return Factory.GetFactory().GetUsersRepository().GetUser(name);
        }

        private void Header()
        {
            Console.WriteLine(" << SHOW USER EXPENSES >> \n");
        }

        private void ShowExpensesList(List<Expense> expenses)
        { 
            foreach(Expense expense in expenses)
                Console.WriteLine(expense);
            
        }

        public void Run()
        {
            User user;
            Header();

            do
            {
                user = GetUser();

            } while (user == null);

            ShowExpensesList(controller.GetUserExpenses(user));

        }
    }
}
