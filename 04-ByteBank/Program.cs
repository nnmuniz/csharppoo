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

            ContaCorrente contaBruno = new ContaCorrente();
            contaBruno.Sacar(1);
            Console.WriteLine(contaBruno.saldo);

            contaBruno.Deposita(11);
            Console.WriteLine(contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();
            contaBruno.Tranferir(1, contaGabriela);

            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
