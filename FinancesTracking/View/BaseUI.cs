using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.View
{
    public abstract class BaseUI
    {

        protected void Header(String option)
        {
            Console.WriteLine(" << " + option + " >> \n");
        }

        public void PrintList(List<Saving> list, string text)
        {
            if (list.Count > 0)
                foreach (Saving saving in list)
                    Console.WriteLine(saving);
            else
                Console.WriteLine(text);
        }

        public void PrintList(List<Expense> list, string text)
        {
            if (list.Count > 0)
                foreach (Expense expense in list)
                    Console.WriteLine(expense);
            else
                Console.WriteLine(text);
        }

        public void PrintList(List<Income> list, string text)
        {
            if (list.Count > 0)
                foreach (Income income in list)
                    Console.WriteLine(income);
            else
                Console.WriteLine(text);
        }

        public int GetMonth()
        {
            int month;
            Console.WriteLine("Which month do you want to consult?");

            int.TryParse(Console.ReadLine(), out month);

            return month;
        }

        public Category GetCategory()
        {
            Console.WriteLine("Choose a category: ");

            foreach (Category _category in Factory.GetFactory().GetCategoriesRepository().GetAllCategories())
            {
                Console.WriteLine(_category.Name);
            }

            string name = Console.ReadLine();

            return Factory.GetFactory().GetCategoriesRepository().GetCategory(name);
        }

        public User GetUser()
        {
            User user;
            do
            {
                Console.WriteLine("Choose an  user: ");

                foreach (User _user in Factory.GetFactory().GetUsersRepository().GetUsers())
                {
                    Console.WriteLine(_user.Name);
                }

                string name = Console.ReadLine();
                user = Factory.GetFactory().GetUsersRepository().GetUser(name);

            } while (user == null);
           

            return user ;
        }

    }
}
