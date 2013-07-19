using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Persistence;
using FinancesTracking.Controller;
using FinancesTracking.Model;

namespace FinancesTracking.Bootstrapper
{
    class SavingsBootstrapper
    {
        public SavingsBootstrapper()
        {
            RegisterSavingController controller = new RegisterSavingController();
            controller.CreateSaving(Factory.GetFactory().GetUsersRepository().GetUser("Vitor"),
                "viagem",
                "viagem",
                1200m,
                150m);

            controller.CreateSaving(Factory.GetFactory().GetUsersRepository().GetUser("Joao"),
                "Carro",
                "comprar carro",
                6000m,
                0m);
        }
    }
}
