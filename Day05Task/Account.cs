namespace Day05Task
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string Name = "Unnamed Account", double Balance = 0.0)
        {
            this.Name = Name;
            this.Balance = Balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public static Account operator +(Account a, Account b)
        {
            string name = a.Name + b.Name;
            return new Account(name, a.Balance + b.Balance);
        }
        public override string ToString()
        {
            return $"{Name} {Balance}";
        }
    }
}
