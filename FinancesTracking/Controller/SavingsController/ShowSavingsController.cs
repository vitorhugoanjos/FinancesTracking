using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller
{
    public class ShowSavingsController
    {
        public List<Saving> ShowAllSavings()
        {
            return Factory.GetFactory().GetSavingsRepository().GetAllSavings();
        }
    }
}
