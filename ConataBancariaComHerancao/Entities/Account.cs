using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConataBancariaComHerancao.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // Protect para disponibilizar na sub-classe. Não permite alteração no Program principal

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDrow(double amount) // Virtual permiteque o metodo seja Sobreescrito em outra classe
        {
            Balance -= amount +5.0;

        }

        public void Deposit(double amount)
        {
            Balance += amount;

        }
    }
}
