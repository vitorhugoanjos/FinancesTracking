using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;
using FinancesTracking.View;
using FinancesTracking.Bootstrapper;

namespace FinancesTracking
{
    class FinancesTracking
    {
        static void Main(string[] args)
        {
            UsersBootstrapper users = new UsersBootstrapper();
            CategoryBootstrapper categories = new CategoryBootstrapper();
            ExpensesBootstrapper expenses = new ExpensesBootstrapper();
            SavingsBootstrapper savings = new SavingsBootstrapper();
            FinancesTrackingUI.GetUI().Run();
        }
    }
}
