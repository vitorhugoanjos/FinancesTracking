using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public class UsersRepository : IUsersRepository
    {

        private static UsersRepository repository = null;

        private List<Model.User> users;

        private UsersRepository()
        {
            users = new List<Model.User>();
        }

        public static UsersRepository GetRepository()
        {
            return repository == null ? (repository = new UsersRepository()) : repository;
        }

        public void RegisterUser(Model.User user)
        {
            users.Add(user);
        }

        public Model.User GetUser(string name)
        {
            foreach (Model.User user in users)
            {
                if (user.Name.Equals(name))
                    return user;
            }

            return null;
        }

        public List<Model.User> GetUsers()
        {
            return users;
        }
    }
}
