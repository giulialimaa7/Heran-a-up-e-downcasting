using System;
using Suposi.Entidades;

namespace Suposi
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta(1001, "Alex", 0.0);
            ContaComercial cc = new ContaComercial(1002, "Maria", 0.0, 500.0);

            // UPCASTING - SUBCLASSE PARA SUPERCLASSE //

            Conta c1 = cc;
            Conta c2 = new ContaComercial(1003, "Bob", 0.0, 200.0);
            Conta c3 = new ContaPoupança (1004, "Anna", 0.0, 0.1);

            // DOWNCASTING - SUPERCLASSE PARA SUBCLASSSE //

            ContaComercial cc4 = (ContaComercial)c2;
            cc4.Empréstimo(200.0);

           // ContaComercial cc5 = (ContaComercial)c3; // ERRO PORQUE C3 É UMA CONTA POUPANÇA (QUE TAMBÉM É UMA SUBCLASSE))

            if (c3 is ContaComercial)
            {
                ContaComercial c5 = (ContaComercial)c3;
                // ContaComercial c5 = c3 as ContaComercial //
                c5.Empréstimo(200.0);
                Console.WriteLine("Emprestimo! ");
            }
            if (c3 is ContaPoupança)
            {
                ContaPoupança c5 = (ContaPoupança)c3;
                // ContaPoupança c5 = c3 as ContaPoupança //
                c5.AtualizarConta();
                Console.WriteLine("Atualizou! ");
            }
        }
    }
}
