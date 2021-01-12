using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha) {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Login realizado com sucesso");
                return true;
            }
            else
            {
                Console.WriteLine("Falha ao realizar login");
                return false;
            }

        }
     }
}
