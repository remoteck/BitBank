using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public class Funcionario {

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public virtual double GetBonificacao() {
            return Salario * 0.10;
        }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf) {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario() {
            Salario *= 1.1;
        }

    }
}
