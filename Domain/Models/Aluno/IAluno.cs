using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Aluno
{
    public interface IAluno
    {
        int idAluno { get; set; }
        string Nome { get; set; }
        string CPF { get; set; }
        DateTime DataNascimento { get; set; }
        Sexo Sexo { get; set; }
    }
}
