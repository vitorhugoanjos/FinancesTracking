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
    public class ShowCategoryUserExpensesUI
    {
        private ShowCategoryExpensesController controller = new ShowCategoryExpensesController();

        private void Header()
        {
            Console.WriteLine(" << SHOW EXPENSES BY USER AND CATEGORY  >> \n");
        }

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

        private Category GetCategory()
        {
            Console.WriteLine("Choose a category: ");

            foreach (Category _category in Factory.GetFactory().GetCategoriesRepository().GetAllCategories())
            {
                Console.WriteLine(_category.Name);
            }

            string name = Console.ReadLine();

            return Factory.GetFactory().GetCategoriesRepository().GetCategory(name);
        }

        private void ShowExpensesList(List<Expense> expenses)
        {
            if (expenses.Count > 0)

                foreach (Expense expense in expenses)
                    Console.WriteLine(expense);

            else
                Console.WriteLine("this user has no expenses in this category");

        }

        public void Run()
        {
            Category category;
            User user;
            Header();

            do
            {
                user = GetUser();

            } while (user == null);

            do
            {
                category = GetCategory();

            } while (category == null);


            List<Expense> expenses = controller.GetCategoryExpenses(category);

            ShowExpensesList(expenses);

        }
    }
}
