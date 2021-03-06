using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld31.Entities
{
    // Casting = converter de um tipo para outro.

    // Upcasting:
    // Casting da subclasse para superclasse
    // Uso comum: Polimorfismo

    // Downcasting:
    // Casting da superclasse para subclasse
    // Palavra 'as'
    // Palavra 'is'
    // Uso comum: Métodos que recebem parâmetros genéricos (ex: Equals)

    // Sealed: Sela um método classe para que não possa ser herdada por outras classes, usado para previnir alguam regra de negócio no projeto.
    // Só é possível selar métodos sobrepostos(override). Sobreposições multiplas podem ser uma porta de entrada para inconsistências, por isso é recomendado selar.
    sealed class SavingsAccount : Account // classe do tipo selada para que não seja possível ter alguma herança do tipo 'SavingsAccount'. // ':' Sintaxe para a classe 'SavingsAccount' herdar todos os atributos e métodos da classe 'Account' (herança).
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) // ': base()' sintaxe para herdar os argumentos do construtor da super classe(base class).
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() // Método para atualizar o saldo com a taxa de juros.
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) // Método para sacar sendo sobrescrito(da super classe).
        {
            // Balance -= amount; // 'override' para que não seja descontada uma taxa no tipo 'SavingsAccount'.

            base.Withdraw(amount); // 'override' reaproveitando a operação da superclasse(base class).
            Balance -= 2.0; // Acrescentando outras funcionalidades pelo meio da sobrescrita(override).
        }
    }
}
