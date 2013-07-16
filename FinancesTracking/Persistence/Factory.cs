using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public class Factory:IFactory
    {
        private static Factory factory = null;

        private Factory() { }

        public static Factory GetFactory()
        {
            return factory == null ? (factory = new Factory()) : factory;
        }

        public IExpensesRepository GetExpensesRepository()
        {
            return ExpenseRepository.GetRepository();
        }


        public IIncomesRepository GetIncomesRepository()
        {
            return IncomesRepository.GetRepository();
        }


        public ISavingsRepository GetSavingsRepository()
        {
            return SavingsRepository.GetRepository();
        }


        public ICategoriesRepository GetCategoriesRepository()
        {
            return CategoriesRepository.GetRepository();
        }

        public IUsersRepository GetUsersRepository()
        {
            return UsersRepository.GetRepository();
        }
    }
}
