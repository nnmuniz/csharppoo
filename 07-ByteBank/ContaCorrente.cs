﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo 
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value; 
            }
        }
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
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
