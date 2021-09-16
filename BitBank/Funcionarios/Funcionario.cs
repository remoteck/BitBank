﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public abstract class Funcionario {

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf) {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

    }
}
