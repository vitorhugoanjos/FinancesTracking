using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public class IncomesRepository:IIncomesRepository
    {
    
        private static IncomesRepository repository = null;

        private List<Model.Income> incomes;

        private IncomesRepository()
        {
            incomes = new List<Model.Income>();
        }

        public static IncomesRepository GetRepository()
        {
            return repository == null ? (repository = new IncomesRepository()) : repository;
        }

        public void RegisterIncome(Model.Income income)
        {
            incomes.Add(income);
        }

        public void RemoveIncome(Model.Income income)
        {
            throw new NotImplementedException();
        }

        public List<Model.Income> GetAllIncomes()
        {
            return incomes;
        }

        public List<Model.Income> GetUserIncomes(Model.User user)
        {
            List<Model.Income> userIncomes = new List<Model.Income>();

            foreach (Model.Income income in incomes)
            {
                if (income.User.Name.Equals(user.Name))
                    userIncomes.Add(income);
            }

            return userIncomes;
        }
    }
}
