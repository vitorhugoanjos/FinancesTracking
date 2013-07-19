using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller;
using FinancesTracking.Persistence;
using FinancesTracking.Model;

namespace FinancesTracking.Bootstrapper
{
    public class IncomingsBootstrapper
    {
        public IncomingsBootstrapper()
        {
            User vitor = Factory.GetFactory().GetUsersRepository().GetUser("Vitor");
            User joao = Factory.GetFactory().GetUsersRepository().GetUser("Joao");
            RegisterIncomeController controller = new RegisterIncomeController();

            controller.CreateIncome(vitor,60m,"Mesada");
            controller.CreateIncome(joao, 40m, "Mesada");
        }
    }
}
