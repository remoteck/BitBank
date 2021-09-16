using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public class Auxiliar : Funcionario {

        public Auxiliar(string cpf) : base(1500, cpf) { }

        public override double GetBonificacao() {
            return Salario * 0.2;
        }

        public override void AumentarSalario() {
            Salario *= 1.10;
        }
    }
}
