using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class Income
    {
        public decimal Amount { get; private set; }

        public string Description { get; private set; }

        public User User { get; private set; }

        public Income(User user, decimal amount, string description)
        {
            User = user;
            Amount = amount;
            Description = description;
            User.DepositCash(amount);
        }

        public Income() { }

        public override string ToString()
        {
            return Description + " - " + Amount + " euros.";  
        }
    }
}
