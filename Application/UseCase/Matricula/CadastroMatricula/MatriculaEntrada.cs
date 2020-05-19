using Domain.Models.Aluno.Enum;
using System;
using System.Collections.Generic;

namespace Application.UseCase.Matricula
{
    public class MatriculaEntrada
    {
        public IEnumerable<int> Disiplinas { get; set; }
        
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public Sexo Sexo { get; set; }
    }
}
