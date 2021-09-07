namespace Heranca.Entities
{
    class AccountBusiness : Account
    {
        public double LoanLimit { get; set; }

        public AccountBusiness()
        {

        }

        public AccountBusiness(double loanLimit, int number, string holder, double balance) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
