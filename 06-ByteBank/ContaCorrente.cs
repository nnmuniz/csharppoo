using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero ;
        private double saldo = 100;

        public void SetSaldo(double saldo)
        {
            if (saldo < 0  )
            {
                return;
            }
                this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor) 
            {
                return false;
            } 
           saldo -= valor;
            return true;
        }

        public void Deposita(double valor)
        {
            saldo += valor;
        }


        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if(saldo < valor)
            {
                return false;
            }
            saldo -= valor;
            contaDestino.Deposita(valor);
            return true;
        }

    }
}
