using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller;
using FinancesTracking.Model;

namespace FinancesTracking.View
{
    public class ShowExpensesUI:BaseUI
    {
        private ShowExpensesController controller = new ShowExpensesController();
     
        public void Run()
        {
            Header("SHOW ALL EXPENSES");
            PrintList(controller.GetAllExpenses(), "There are no expenses registered");
        }
    }
}
