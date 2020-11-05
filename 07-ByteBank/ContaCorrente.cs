using _07_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    //public class ContaCorrente
    //{
    //    private Cliente _titular;

    //    public Cliente Titular
    //    {
    //        get
    //        {
    //            return _titular;
    //        }
    //        set
    //        {
    //            _titular = value;
    //        }
    //    }
    // se o get e set for o retorno padrão do método e não tiver lógica, só retornar e setar valor não precisa criar o campo e preencher o bloco get e set. colocar na mesma linha

    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100; // Encapsulamento o campo saldo não fica exposto ele fica reservado / privado e a manipulação é feita atraves dos métodos DefinirSaldo (set) ObterSaldo (Get).
        // _nome minisculo por convenção.

        public double Saldo // Método get e set primeira letra em maiusculo 
        {
            get
            {
                return _saldo; // get sempre retorna 
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value; // palavra reservada, representa o argumento do set. // set define a propriedade
                                // A palavra reservada value existe somente dentro de um setter.

            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor) 
            {
                return false;
            } 
           _saldo -= valor;
            return true;
        }

        public void Deposita(double valor)
        {
            _saldo += valor;
        }


        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if(_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Deposita(valor);
            return true;
        }

    }
}
