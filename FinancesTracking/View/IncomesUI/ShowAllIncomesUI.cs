using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller.IncomesController;

namespace FinancesTracking.View.IncomesUI
{
    public class ShowAllIncomesUI : BaseUI
    {
        private ShowAllIncomesController controller = new ShowAllIncomesController();

        public void Run()
        {
            Header("SHOW ALL INCOMES");
            PrintList(controller.GetAllIncomes(), "There are no incomes registered");
        }
    }
}
