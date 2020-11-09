using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Cliente cliente = new Cliente();

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            cliente.Nome = "Nathalya";
            cliente.CPF = "438.218.154-05";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            ContaCorrente contaAtualizada = new ContaCorrente(868, 86712540);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
