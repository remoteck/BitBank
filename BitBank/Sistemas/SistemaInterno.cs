using BitBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Sistemas {
    public class SistemaInterno {

        public bool Logar(Autenticavel funcionario, string senha) {
            
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado) { 
                Console.WriteLine($"Bem-vindo ao sistema! {funcionario.Nome}");
                return true;
            }
            else {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

    }
}
