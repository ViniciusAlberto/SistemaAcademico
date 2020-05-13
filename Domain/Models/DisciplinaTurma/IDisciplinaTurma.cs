using Domain.Models.Disciplina;
using Domain.Models.Turma;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.DisciplinaTurma
{
    public interface IDisciplinaTurma
    {
        IDisciplina Disciplina { get; set; }

        ITurma Turma { get; set; }
    }
}
