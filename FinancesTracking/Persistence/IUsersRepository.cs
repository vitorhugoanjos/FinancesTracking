using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public interface IUsersRepository
    {
        void RegisterUser(Model.User user);
        Model.User GetUser(string name);
        List<Model.User> GetUsers();
    }
}
