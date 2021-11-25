using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConataBancariaComHerancao.Entities
{
    /*sealed - Faz com que a classe não possa ser herdada, evitando sub-classes da mesma */

    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }


       

        static SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestrate)
          :base (number, holder, balance) // Aproveita o construtor da super-classe
        {

            InterestRate = interestrate;

        }



        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }


        /*  selead faz com que  o metodo não possa ser Sobreescrito em outra classe
         *  Usado em metodos Sobre-postos */

        public sealed override void WithDrow(double amount)
        {
            /*Funciona como um desvio, aproveita a implementação da super-classe fazendo a operação
              Depois faz o desconto da taxa */

            base.WithDrow(amount); 
            Balance -= 2.0;
        }
    }
}
