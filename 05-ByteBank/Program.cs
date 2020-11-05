using _01_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Gabriela";
            cliente.profissao = "Desenvolvedora";
            cliente.cpf = "438.578.618-77";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = cliente;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(cliente.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
