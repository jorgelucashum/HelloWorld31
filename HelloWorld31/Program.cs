using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld31.Entities;

namespace HelloWorld31
{
// Herança:
// É um tipo de associação que permite que uma classe herde dados e comportamentos de outra.
// Sintaxe:
// ':' = estende
// 'base' = referência para a superclasse

// Sobrposição ou Sobreescrita:
// É a implementação de uim método de uma superclasse na subclasse
// - Para um método comum (Não abstrato) possa ser sobreposto, deve ser incluído nele o prefixo: "virtual".
// - Ao sobrescrever um método, devemos incluir nele o prefixo: "override";

    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10.0); // Saque normal(Tipo 'Account').
            acc2.Withdraw(10.0); // Saque usando o método override da super classe(Tipo 'SavingsAccount').

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


            Console.ReadLine();
        } 
    }
}
