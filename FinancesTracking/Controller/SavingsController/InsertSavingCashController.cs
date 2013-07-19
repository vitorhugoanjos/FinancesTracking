using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller.SavingsController
{
    public class InsertSavingCashController
    {
        public string InsertCash(Saving saving, decimal amount)
        {
            return saving.DepositCash(amount);
        }
    }
}
