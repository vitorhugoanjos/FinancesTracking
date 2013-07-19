using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller;

namespace FinancesTracking.View
{
    public class ShowUserSavingsUI:BaseUI
    {
        private ShowUserSavingsController controller = new ShowUserSavingsController();

        public void Run()
        {
            Header("SHOW USER'S SAVINGS");
            PrintList(controller.GetUserSavings(GetUser()), "This user has no savings registered.");
        }
    }
}
