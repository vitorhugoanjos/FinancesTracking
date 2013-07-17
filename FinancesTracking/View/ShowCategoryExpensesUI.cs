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
    public class ShowCategoryExpensesUI
    {
        private ShowCategoryExpensesController controller = new ShowCategoryExpensesController();

        private void Header()
        {
            Console.WriteLine(" << SHOW CATEGORY'S EXPENSES  >> \n");
        }

        private Category GetCategory()
        {
            Console.WriteLine("Choose a category: ");

            foreach (Category _category in Factory.GetFactory().GetCategoriesRepository().GetAllCategories())
            {
                Console.WriteLine(_category.Name);
            }

            string name = Console.ReadLine();

            return Factory.GetFactory().GetCategoriesRepository().GetCategory(name);
        }

        private void ShowExpensesList(List<Expense> expenses)
        {
            if (expenses.Count > 0)

                foreach (Expense expense in expenses)
                    Console.WriteLine(expense);

            else
                Console.WriteLine("This category has no expenses");

        }

        public void Run()
        {
            Category category;

            Header();

            do
            {
                category = GetCategory();

            } while (category == null);

            List<Expense> expenses = controller.GetCategoryExpenses(category);

            ShowExpensesList(expenses);

        }
    }
}
