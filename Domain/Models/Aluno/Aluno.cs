﻿using Domain.Models.Aluno.Enum;
using System;

namespace Domain.Models.Aluno
{
    public class Aluno : IAluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Sexo Sexo { get; set; }
    }
}
