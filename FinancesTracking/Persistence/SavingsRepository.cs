using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public class SavingsRepository:ISavingsRepository
    {
        private static SavingsRepository repository = null;

        private List<Model.Saving> savings;

        private SavingsRepository()
        { 
            savings = new List<Model.Saving>();
        }

        public static SavingsRepository GetRepository()
        {
            return repository == null ? (repository = new SavingsRepository()) : repository;
        }

        public void RegisterSaving(Model.Saving saving)
        {
            savings.Add(saving);
        }

        public void RemoveSaving(Model.Saving saving)
        {
            throw new NotImplementedException();
        }

        public List<Model.Saving> GetAllSavings()
        {
            return savings;
        }
    }
}
