namespace Day05Task
{
    internal class SavingsAccount : Account
    {

        public double InterestRate { get; set; }
        public SavingsAccount(string Name = "Unnamed Account", double Balance = 0.0, double interestRate = 0) : base(Name, Balance)
        {
            this.Name = Name;
            this.Balance = Balance;
            InterestRate = interestRate;
        }
        public override bool Deposit(double amount)
        {
            return base.Deposit(amount + InterestRate);
        }
    }
}