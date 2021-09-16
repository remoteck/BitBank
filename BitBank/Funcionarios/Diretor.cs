using BitBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public class Diretor : Autenticavel {

        public Diretor(string cpf) : base(8000, cpf) { }

        public override double GetBonificacao() {
            return Salario * 0.5;
        }

        public override void AumentarSalario() {
            Salario *= 1.15;
        }

    }
}