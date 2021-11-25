using System;
using ConataBancariaComHerancao.Entities;

namespace ConataBancariaComHerancao
{
    class Program
    {
        static void Main(string[] args)
        {

            BusinessAccount account = new BusinessAccount(1080, "JOSE LUIS", 1500, 500);
            Console.WriteLine(account.Balance);

            // Casting e Upcasting


            Account acc = new Account(1080,"Zeka", 0.0);
            BusinessAccount bacc = new BusinessAccount(1022, "Guilherme", 0.00, 500);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(10566, "Sara", 500, 250);
            Account acc3 = new SavingsAccount(10569, "Neia", 800, 0.01);

            //DOWCASTING

            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100);
            // acc2 não tem Loan pq e do tipoo Account

            //BusinessAccount acc5 = (BusinessAccount)acc3 -- não permite pq acc3 e do tipo SavingsAccount

            if(acc3 is BusinessAccount) // Verifica se acc3 3 instancia de BusinessAccount
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;  // outra forma de fazer CASTING
                acc5.Loan(200);
                Console.WriteLine("Emprestimo feito");
            }

            if (acc3 is SavingsAccount)
            {

                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; // outra forma de fazer CASTING
                acc5.UpdateBalance();
            }
            // Tetando sobreescrita de method
            Account acc6 = new Account(10266, "Joao", 500.0);
            Account acc7 = new SavingsAccount(12486, "Zira", 500, 0.01);

            acc6.WithDrow(10.0);
            acc7.WithDrow(10.0);

            Console.WriteLine("Conta Normal - Acc6 Saldo: " + acc6.Balance);
            Console.WriteLine("Conta Poupança - Acc7 Saldo: " + acc7.Balance);

        }
    }
}
