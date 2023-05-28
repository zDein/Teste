using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main()
        {
            ContaBancaria p;

            double deposito;

            Console.Write("Entre com o número da conta: ");
            int numero_conta = Convert.ToInt16(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            p = new ContaBancaria(numero_conta, titular);

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = Convert.ToChar((Console.ReadLine()));

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.deposito(deposito);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);

        }
    }
}
