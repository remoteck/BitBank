﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public class Diretor : Funcionario {

        public double GetBonificacao() {
            return Salario;
        }

    }
}
