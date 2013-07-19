using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller.SavingsController
{
    public class TakeSavingCashController
    {
        public Boolean TakeCash(Saving saving, decimal amount)
        {
            if (saving.CanWithdrawCash(amount))
            {
                saving.WithdrawCash(amount);
                return true;
            }

            return false;
        }
    }
}
