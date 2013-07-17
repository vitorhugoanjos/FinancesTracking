using FinancesTracking.Controller;
using FinancesTracking.Model;
using FinancesTracking.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.View
{
    public class ShowBalanceUI
    {
        private ShowBalanceController controller = new ShowBalanceController();

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


        public void Run()
        {
            User user;
       
            Console.WriteLine(" << SHOW BALANCE >> ");

            do
            {
                user = GetUser();

            } while (user == null);

            double balance = controller.GetBalance(user);

            Console.WriteLine("\n\t{0}'s balance is: {1} euros", user.Name, user.Balance);

        }
    }
}
