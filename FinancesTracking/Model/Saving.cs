using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesTracking.Model
{
    public class Saving
    {

        public string GoalName { get; private set;}

        public string Description { get; private set; }

        public decimal GoalAmount { get; private set; }

        public decimal InitialAmount { get; private set; }

        public decimal CurrentAmount { get; private set; }

        public bool HasReachedGoal { get; private set; }

        public User User { get; private set; }


        public Saving(User user, string goalName, string description, decimal goalAmount, decimal initialAmount)
        {
            User = user;
            GoalName = goalName;
            Description = description;
            GoalAmount = goalAmount;
            InitialAmount = initialAmount;
            User.WithdrawCash(initialAmount);
            DepositCash(initialAmount);
        }


        public Saving() { }

        public string DepositCash(decimal cashToDeposit)
        {
            if ((CurrentAmount + cashToDeposit) > GoalAmount)
                return "EXCEEDS_GOAL";

            if ((CurrentAmount + cashToDeposit) == GoalAmount)
            {
                CurrentAmount += cashToDeposit;
                HasReachedGoal = true;
                return "GOAL_ACHIEVED";
            }

            CurrentAmount += cashToDeposit;
            return "DEPOSITED";
        }

        public Boolean CanWithdrawCash(decimal cashTowithdrawal)
        {
            return (CurrentAmount >= cashTowithdrawal);
        }

        public void WithdrawCash(decimal cashTowithdrawal)
        {
            if(CanWithdrawCash(cashTowithdrawal))
            {
                CurrentAmount -= cashTowithdrawal;
            }
        }

        public override string ToString()
        {
            return GoalName + " - Goal: " + GoalAmount + " euros - Currently have: " + CurrentAmount + " euros.";
        }
    }
}
