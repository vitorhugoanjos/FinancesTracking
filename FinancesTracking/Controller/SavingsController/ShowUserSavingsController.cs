using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class ShowUserSavingsController
    {
        public List<Saving> GetUserSavings(User user)
        {
            List<Saving> savings = Factory.GetFactory().GetSavingsRepository().GetAllSavings();
            List<Saving> toReturn = new List<Saving>();

            if (savings.Count > 0)
            {

                foreach (Saving saving in savings)
                {
                    if (saving.User.Name.Equals(user.Name))
                    {
                        toReturn.Add(saving);
                    }
                }
            }

            return toReturn;
        }
    }
}
