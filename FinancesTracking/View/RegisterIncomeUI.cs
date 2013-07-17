using FinancesTracking.Controller;
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
    public class RegisterIncomeUI
    {
        private RegisterIncomeController controller = new RegisterIncomeController();

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

        public void Run()
        {
            User user;
            string comment;
            double amount;

            Console.WriteLine(" << REGISTER INCOME >> ");

            do
            {
                user = GetUser();

            } while (user == null);

            comment = GetComment();
            amount = GetAmount();

            controller.CreateIncome(user, amount, comment);

        }
    }
}
