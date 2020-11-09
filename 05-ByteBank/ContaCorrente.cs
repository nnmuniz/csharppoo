using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero ;
        public double saldo = 100;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor) 
            {
                return false;
            } 
            this.saldo -= valor;
            return true;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }


        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Deposita(valor);
            return true;
        }
    }
}
