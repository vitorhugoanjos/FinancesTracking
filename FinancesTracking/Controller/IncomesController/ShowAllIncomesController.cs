using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;

namespace FinancesTracking.Controller.IncomesController
{
    public class ShowAllIncomesController
    {
        public List<Income> GetAllIncomes()
        {
            return Factory.GetFactory().GetIncomesRepository().GetAllIncomes();
        }
    }
}
