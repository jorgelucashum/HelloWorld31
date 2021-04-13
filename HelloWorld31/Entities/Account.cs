using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld31.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } // 'private' somente a própria classe pode realizar alterações.
        public double Balance { get; protected set; } // o encapsulamento do tipo 'protected' permite sofrer alterações por subclasses (herança).

        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Método para sacar
        public virtual void Withdraw(double amount) // O 'virtual' permite que o método seja sobrescrito.
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount) // Método para depositar.
        {
            Balance += amount;
        }


    }
}
