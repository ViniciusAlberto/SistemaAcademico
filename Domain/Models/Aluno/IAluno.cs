using System;

namespace Domain.Models.Aluno
{
    public interface IAluno
    {
        int IdAluno { get; set; }

        string Nome { get; set; }

        string CPF { get; set; }

        DateTime DataNascimento { get; set; }

        DateTime DataCadastro { get; set; }

        Enum.Sexo Sexo { get; set; }
    }
}
