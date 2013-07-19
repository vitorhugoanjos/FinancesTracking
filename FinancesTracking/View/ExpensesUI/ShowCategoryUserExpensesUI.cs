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
    public class ShowCategoryUserExpensesUI : BaseUI
    {
        private ShowCategoryUserExpensesController controller = new ShowCategoryUserExpensesController();

        public void Run()
        {
            Category category;
            User user;

            Header("SHOW EXPENSES BY USER AND CATEGORY");
            user = GetUser();
            category = GetCategory();

            List<Expense> expenses = controller.GetCategoryExpenses(category, user);

            PrintList(expenses, "this user has no expenses in this category");

        }
    }
}
