using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Persistence
{
    public interface ISavingsRepository
    {
        void RegisterSaving(Model.Saving saving);
        void RemoveSaving(Model.Saving saving);
        List<Model.Saving> GetAllSavings();
    }
}
