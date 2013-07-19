using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller.SavingsController;
using FinancesTracking.Model;

namespace FinancesTracking.View.SavingsUI
{
    public class InsertSavingCashUI : BaseUI
    {

        private InsertSavingCashController controller = new InsertSavingCashController();



        public void Run()
        {
            Header("INSERT CASH INTO SAVING");
            Saving saving = GetSaving();
            decimal amount;
            string result;

            do
            {
                amount = GetAmount();
                result = controller.InsertCash(saving, amount);
            } while (result.Equals("EXCEEDS_GOAL"));

            if (result.Equals("DEPOSITED"))
            {
                Console.WriteLine("DEPOSITED\n");
                Console.WriteLine(saving);
            }

            if (result.Equals("GOAL_ACHIEVED"))
            {
                Console.WriteLine("DEPOSITED\n");
                Console.WriteLine("Congratulations, you have achieved your goal!");
            }



        }
    }
}
