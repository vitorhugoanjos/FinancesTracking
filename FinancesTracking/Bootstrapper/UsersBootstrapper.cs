using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Persistence;
using FinancesTracking.Model;

namespace FinancesTracking.Bootstrapper
{
    public class UsersBootstrapper
    {
        public UsersBootstrapper()
       {
           Factory.GetFactory().GetUsersRepository().RegisterUser(new User("Vitor", 160));
           Factory.GetFactory().GetUsersRepository().RegisterUser(new User("Joao", 50));
       }
    }
}
