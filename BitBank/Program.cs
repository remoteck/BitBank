using BitBank.Funcionarios;
using BitBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank {
    class Program {
        static void Main(string[] args) {

            CalculaBonificacao();
            AcessoInterno();
            
            Console.ReadLine();
        }

        public static void AcessoInterno() {

            SistemaInterno sistemaInterno= new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04") {
                Nome = "Roberta"
            };

            roberta.Senha = "123";
            sistemaInterno.Logar(roberta, "123");

            GerenteContas camila = new GerenteContas("326.985.628-89") {
                Nome = "Camila"
            };

            camila.Senha = "abc";
            sistemaInterno.Logar(camila, "abc");
        }
        
        public static void CalculaBonificacao() {

            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39") {
                Nome = "Pedro"
            };

            Diretor roberta = new Diretor("159.753.398-04") {
                Nome = "Roberta"
            };

            Auxiliar igor = new Auxiliar("981.198.778-53") {
                Nome = "Igor"
            };

            GerenteContas camila = new GerenteContas("326.985.628-89") {
                Nome = "Camila"
            };

            Desenvolvedor guilherme = new Desenvolvedor("449.466.648-31") {
                Nome = "Guilherme"
            };

            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine($"Total de bonificações do mês: R${gerenciadorBonificacao.GetTotalBonificacao()}");

        }
    }
}
