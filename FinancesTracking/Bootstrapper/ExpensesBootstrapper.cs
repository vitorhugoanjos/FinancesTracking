using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Bootstrapper
{
    class ExpensesBootstrapper
    {
        public ExpensesBootstrapper()
        {
            Factory.GetFactory().GetExpensesRepository().RegisterExpense(new Expense(Factory.GetFactory().GetUsersRepository().GetUser("Vitor"),"Cachorro",2,Factory.GetFactory().GetCategoriesRepository().GetCategory("Alimentacao"),DateTime.Today));
            Factory.GetFactory().GetExpensesRepository().RegisterExpense(new Expense(Factory.GetFactory().GetUsersRepository().GetUser("Vitor"), "Fanta", 1, Factory.GetFactory().GetCategoriesRepository().GetCategory("Alimentacao"), DateTime.Today));
            Factory.GetFactory().GetExpensesRepository().RegisterExpense(new Expense(Factory.GetFactory().GetUsersRepository().GetUser("Joao"), "Chocolate", 0.70, Factory.GetFactory().GetCategoriesRepository().GetCategory("Alimentacao"), DateTime.Today));
            Factory.GetFactory().GetExpensesRepository().RegisterExpense(new Expense(Factory.GetFactory().GetUsersRepository().GetUser("Joao"), "Sumo", 0.70, Factory.GetFactory().GetCategoriesRepository().GetCategory("Alimentacao"), new DateTime(2013,6,5)));
        }
    }
}
