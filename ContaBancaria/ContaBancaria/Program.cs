using System;

namespace Banco
{
    class Program
    {
        static void Main()
        {
            Console.Write("Entre com o número da conta: ");
            int numero_conta = Convert.ToInt16((Console.ReadLine()));

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            char opcao = Convert.ToChar((Console.ReadLine()));

            if(opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double deposito = Convert.ToDouble((Console.ReadLine()));
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);

            Console.Write("Entre com um valor para depósito: ");
            deposito = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);

            Console.Write("Entre com um valor para saque: ");
            deposito = Convert.ToDouble((Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p);

        }
    }
}
