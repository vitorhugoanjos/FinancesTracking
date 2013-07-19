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
    public class RegisterSavingUI:BaseUI
    {
        private RegisterSavingController controller = new RegisterSavingController();


        private String GetName()
        {
            Console.WriteLine("Write the goal title: ");
            return Console.ReadLine();
        }

        private decimal GetAmount(string type)
        {
            decimal amount;
            Console.WriteLine("Insert " + type + " amount: ");
            decimal.TryParse(Console.ReadLine(), out amount);
            return amount;
        }

        private Boolean isValid(decimal goalAmount, decimal initialAmount, User user)
        {
            return ((initialAmount < goalAmount) && (controller.CanCreateSaving(user, initialAmount)));
        }

        public void Run()
        {
            User user;
            string goalName;
            string coment;
            decimal goalAmount;
            decimal initialAmount;

           Header("REGISTER SAVING");
            
            user = GetUser();
            goalName = GetName();
            coment = GetComment();
            goalAmount = GetAmount("goal");

            do
            {
                initialAmount = GetAmount("initial");
            } while (!isValid(goalAmount, initialAmount, user));

            controller.CreateSaving(user,goalName,coment,goalAmount,initialAmount);

        }

    }
}
