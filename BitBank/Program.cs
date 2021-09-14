using BitBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank {
    class Program {
        static void Main(string[] args) {

            Diretor gui = new Diretor(8500, "44946664831") {
                Nome = "Guilherme"
            };

            Funcionario leo = new Funcionario(1500, "8196816851") {
                Nome = "Leona"
            };

            Funcionario mari = gui;

            Console.WriteLine($"Nome do Diretor: {gui.Nome}");
            Console.WriteLine($"Nome do Funcionário: {leo.Nome}\n");

            Console.WriteLine($"Bonificação de uma referência Diretor: {gui.GetBonificacao()}");
            Console.WriteLine($"Bonificação de uma referência Funcionário: {leo.GetBonificacao()}\n");

            Console.WriteLine($"Salário Funcionário: R${leo.Salario}");
            Console.WriteLine($"Salário Diretor: R${gui.Salario}\n");

            Console.WriteLine($"Referência de Leona: {leo.GetType()}");
            Console.WriteLine($"Referência de Guilherme: {gui.GetType()}\n");

            Console.WriteLine($"Quantidade de Funcionários: {Funcionario.TotalDeFuncionarios}\n");
            //Só aparecem 2 funcionários por que 'mari' está usando a mesma referência que 'gui'.

            gui.AumentarSalario();
            leo.AumentarSalario();
            Console.WriteLine($"Novo salário do Funcionário: R${leo.Salario}");
            Console.WriteLine($"Novo salário do Diretor: R${gui.Salario}");

            Console.ReadLine();
        }
    }
}
