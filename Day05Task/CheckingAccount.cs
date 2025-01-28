namespace Day05Task
{
    internal class CheckingAccount : Account
    {
        private const double Fee = 1.50;
        public CheckingAccount(string Name = "Unnamed Account", double Balance = 0.0) : base(Name, Balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }
        public override string ToString()
        {
            return $"Checking Account Name: {Name}, Balance: {Balance:C}, Withdrawal Fee: {Fee:C}";
        }
    }
}