using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Controller;

namespace FinancesTracking.View
{
    public class ShowAllSavingsUI : BaseUI
    {
        private ShowSavingsController controller = new ShowSavingsController();

        public void Run()
        {
            Header("SHOW ALL SAVINGS");
            PrintList(controller.ShowAllSavings(), "There are no savings registered");
        }
    }
}
