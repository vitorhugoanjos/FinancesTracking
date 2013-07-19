using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancesTracking.Model;
using FinancesTracking.Persistence;
using FinancesTracking.Controller;

namespace FinancesTracking.View
{
    public class ShowMonthExpensesUI : BaseUI
    {

        private ShowMonthExpensescontroller controller = new ShowMonthExpensescontroller();

        public void Run()
        {
            Header("SHOW MONTH EXPENSES");

            List<Expense> expenses = controller.GetMonthExpenses(GetMonth());
            PrintList(expenses,"There were no expenses registered in this month");

        }


    }
}
