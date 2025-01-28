namespace Day05Task
{
    internal class TrustAccount : SavingsAccount
    {
        private const int MaxYear = 3;
        private int YearsCounter = 0;
        public TrustAccount(string Name = "Unnamed Account", double Balance = 0.0, double interestRate = 0.0) : base(Name, Balance, interestRate)
        {

        }
        public override bool Deposit(double amount)
        {
            if (amount <= 5000)
            {
                return base.Deposit(amount + 50);
            }
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            if (YearsCounter >= MaxYear || amount > Balance * 0.2)
            {
                return false;
            }
            YearsCounter++;
            return base.Withdraw(amount);
        }

        public override string ToString()
        {
            return $"Trust Account Name: {Name}, Balance: {Balance:F}, Interest Rate: {InterestRate}%, Withdrawals This Year: {YearsCounter}";
        }
    }
}