

namespace ConataBancariaComHerancao.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

         static BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanlimit)
            :base(number, holder, balance) // Aproveita o Construtor da classe extendida
        {
            LoanLimit = LoanLimit;
        }

        public void Loan(double amount)
        {
            if(LoanLimit <= amount) // Verifica se o valor esta dentro do limite
            {

                Balance += amount;
            }

        }

    }
}
