using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller;
using FinancesTracking.Model;

namespace FinancesTracking.View.IncomesUI
{
    public class ShowUserIncomesUI : BaseUI
    {
        private ShowUserIncomesController controller = new ShowUserIncomesController();

        public void Run()
        {
            Header("SHOW USER'S INCOMINGS");
            User user = GetUser();
            
            PrintList(controller.GetUserIncomes(user), "This user has no incomings");
        }
    }
}
