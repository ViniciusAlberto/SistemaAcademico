using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.DisciplinaMatricula.CancelamentoMatricula
{
    public class CancelamentoMatriculaEntrada
    {
        public int IdMatricula { get; set; }

        public int IdDisciplina { get; set; }

        public int IdAluno { get; set; }
    }
}
