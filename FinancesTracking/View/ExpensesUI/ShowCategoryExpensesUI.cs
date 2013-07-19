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
    public class ShowCategoryExpensesUI : BaseUI
    {
        private ShowCategoryExpensesController controller = new ShowCategoryExpensesController();

        public void Run()
        {
            Category category;

            Header("SHOW CATEGORY'S EXPENSES");
            category = GetCategory();

            List<Expense> expenses = controller.GetCategoryExpenses(category);
            PrintList(expenses, "This category has no expenses");

        }
    }
}
