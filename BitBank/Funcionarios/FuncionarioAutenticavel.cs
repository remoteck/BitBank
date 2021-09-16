﻿using BitBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank.Funcionarios {
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel {

        public string Senha { get; set; }

        protected FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf) { }

        public bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
