using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {

        //public string nome;
        //public string cpf;
        //public string profissao;
        // repetitivo, public + tipo + nome + get e set, tem um jeito mais rápido. 
        // public int MyProperty { get; set; }  prop MyProperty - Andar com tab e enter, otimizar tempo 
        // Beneficio do encapsulamento porque você acaba fazendo alterações nos getter e setters e não é necessário alterar toda a aplicação. 

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; } // Por trás do código o compilador cria um campo privado para a Profissao e 2 métodos para o Get_Profissao e Set_Profissao

    }
}
