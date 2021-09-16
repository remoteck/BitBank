using BitBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public class GerenteContas : Autenticavel {
        public GerenteContas(string cpf) : base(5000, cpf) { }

        public override double GetBonificacao() {
            return Salario * 0.25;
        }

        public override void AumentarSalario() {
            Salario *= 1.05;
        }
    }
}
