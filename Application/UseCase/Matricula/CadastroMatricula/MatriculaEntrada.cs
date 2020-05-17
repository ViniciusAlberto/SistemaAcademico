using Domain.Models.Aluno.Enum;
using System;

namespace Application.UseCase.Matricula
{
    public class MatriculaEntrada
    {
        public int IdTurmaDisciplina { get; set; }
        
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public Sexo Sexo { get; set; }
    }
}
