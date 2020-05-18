using Domain.Models.Aluno;
using Domain.Models.DisciplinaMatricula;
using System;
using System.Collections.Generic;

namespace Domain.Models.Matricula
{
    public interface IMatricula
    {
        int IdMatricula { get; set; }

        IAluno Aluno { get; set; }

        DateTime DataMatricula { get; set; }

        List<IDisciplinaMatricula> DisciplinaMatricula { get; set; }
    }
}
