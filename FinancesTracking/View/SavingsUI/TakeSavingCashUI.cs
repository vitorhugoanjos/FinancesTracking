using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller.SavingsController;
using FinancesTracking.Model;

namespace FinancesTracking.View.SavingsUI
{
    public class TakeSavingCashUI : BaseUI
    {
        private TakeSavingCashController controller = new TakeSavingCashController();

        public void Run()
        {
            Header("TAKE SAVING'S CASH");
            Saving saving = GetSaving();
            decimal amount;
            Boolean result;

            do
            {
                amount = GetAmount();
                result = controller.TakeCash(saving, amount);
            } while (!result);

            if (result)
            {
                Console.WriteLine("WITHDRAWN\n");
                Console.WriteLine(saving);
            }

        }
    }
}
