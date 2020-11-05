using _01_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.agencia = 863;
            conta.numero = 863452;

            ContaCorrente contas = new ContaCorrente();
            contas.titular = "Gabriela";
            contas.agencia = 863;
            contas.numero = 863452;

            Console.ReadLine();
        }
    }
}
