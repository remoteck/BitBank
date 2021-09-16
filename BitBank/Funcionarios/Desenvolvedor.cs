using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public class Desenvolvedor : Funcionario {
        public Desenvolvedor(string cpf) : base(4500, cpf) { }

        public override void AumentarSalario() {
            Salario *= 2;
        }

        public override double GetBonificacao() {
            return Salario * 0.50;
        }
    }
}
