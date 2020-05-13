using Domain.Models.Aluno;
using Domain.Models.Disciplina;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Matricula
{
    public interface IMatricula
    {
         int idMatricula { get; set; }

         IAluno Aluno { get; set; }

        List<IDisciplina> Disciplinas { get; set; }
    }
}
