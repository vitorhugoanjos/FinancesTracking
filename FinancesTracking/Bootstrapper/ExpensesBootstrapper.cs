using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Controller;
using FinancesTracking.Persistence;

namespace FinancesTracking.Bootstrapper
{
    class ExpensesBootstrapper
    {
        public ExpensesBootstrapper()
        {
            RegisterExpenseController controller = new RegisterExpenseController();
            User vitor = Factory.GetFactory().GetUsersRepository().GetUser("Vitor");
            User joao = Factory.GetFactory().GetUsersRepository().GetUser("Joao");
            Category alimentacao = Factory.GetFactory().GetCategoriesRepository().GetCategory("Alimentacao");
            //Category lazer = Factory.GetFactory().GetCategoriesRepository().GetCategory("Lazer");


            controller.CreateExpense(vitor, "Cachorro", 2m, alimentacao, DateTime.Today);
            controller.CreateExpense(vitor, "Fanta", 1m, alimentacao, DateTime.Today);
            controller.CreateExpense(joao, "Sumo", 0.70m, alimentacao, new DateTime(2013, 6, 5));
        }
    }
}
