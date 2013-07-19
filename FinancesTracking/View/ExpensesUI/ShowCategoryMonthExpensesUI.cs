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
    public class ShowCategoryMonthExpensesUI : BaseUI
    {

        private ShowCategoryMonthExpensescontroller controller = new ShowCategoryMonthExpensescontroller();

        public void Run()
        {
            Category category;

            Header("SHOW MONTH/CATEGORY EXPENSES");
            category = GetCategory();

            PrintList(controller.GetMonthExpenses(GetMonth(), category), "There were no expenses registered in this month with this category");

        }

    }
}
