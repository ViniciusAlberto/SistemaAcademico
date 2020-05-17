using Domain.Models.Aluno.Enum;
using System;

namespace Application.UseCase.Aluno
{
    public class AlunoEntrada
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Sexo Sexo { get; set; }
    }
}
