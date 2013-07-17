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
    public class ShowCategoryMonthExpensesUI
    {

        private ShowCategoryMonthExpensescontroller controller = new ShowCategoryMonthExpensescontroller();

        private void Header()
        {
            Console.WriteLine(" << SHOW MONTH/CATEGORY EXPENSES >> \n");
        }

        private void ShowExpensesList(List<Expense> expenses)
        {
            if (expenses.Count > 0)
                foreach (Expense expense in expenses)
                    Console.WriteLine(expense);
            else
                Console.WriteLine("There were no expenses registered in this month\n with this category");
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

        private int GetMonth()
        {
            int month;
            Console.WriteLine("Which month do you want to consult?");
            int.TryParse(Console.ReadLine(), out month);

            return month;
        }

        public void Run()
        {
            Category category;

            Header();

            do
            {
                category = GetCategory();

            } while (category == null);

            List<Expense> expenses = controller.GetMonthExpenses(GetMonth(), category);
            ShowExpensesList(expenses);

        }

    }
}
