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
    public class RegisterSavingUI
    {
        private RegisterSavingController controller = new RegisterSavingController();

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

        private String GetName()
        {
            Console.WriteLine("Write the goal title: ");
            return Console.ReadLine();
        }

        private double GetAmount(string type)
        {
            double amount;
            Console.WriteLine("Insert " + type + " amount: ");
            Double.TryParse(Console.ReadLine(), out amount);
            return amount;
        }

        public void Run()
        {
            User user;
            string goalName;
            string coment;
            double goalAmount;
            double initialAmount;

            Console.WriteLine(" << REGISTER SAVING >> ");

            do
            {
                user = GetUser();

            } while (user == null);

            goalName = GetName();
            coment = GetComment();
            goalAmount = GetAmount("goal");
            initialAmount = GetAmount("initial");

            controller.CreateSaving(user,goalName,coment,goalAmount,initialAmount);

        }
    }
}
