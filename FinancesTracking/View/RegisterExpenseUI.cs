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
    public class RegisterExpenseUI
    {

        private RegisterExpenseController controller = new RegisterExpenseController();

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

        private String GetComment()
        {
            Console.WriteLine("Write a comment: ");
            return Console.ReadLine();
        }

        private double GetAmount()
        {
            double amount;
            Console.WriteLine("Insert amount: ");
            Double.TryParse(Console.ReadLine(), out amount);
            return amount;
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

        public void Run()
        { 
            User user;
            string comment;
            double amount;
            Category category;
            DateTime date;

            Console.WriteLine(" << REGISTER EXPENSE >> ");

            do
            {
                user = GetUser();

            } while (user == null);

            comment = GetComment();
            amount = GetAmount();

            do
            {
                category = GetCategory();

            } while (category == null);

            date = DateTime.Today;

            controller.CreateExpense(user, comment, amount, category, date);
            
        }
    }
}
