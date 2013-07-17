using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class RegisterSavingController
    {
        public void CreateSaving(User user, string goalName, string description, double goalAmount, double initialAmount)
        {
            Saving saving = new Saving(user, goalName, description, goalAmount, initialAmount);
            Factory.GetFactory().GetSavingsRepository().RegisterSaving(saving);
        }
    }
}
