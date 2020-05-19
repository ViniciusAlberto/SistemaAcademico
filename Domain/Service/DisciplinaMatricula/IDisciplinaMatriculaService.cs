using Domain.Models.Disciplina;
using Domain.Models.DisciplinaMatricula;
using Domain.Models.Matricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.DisciplinaMatricula
{
    public interface IDisciplinaMatriculaService
    {
        Task<bool> CancelamentoMatriculaAsync(IDisciplinaMatricula disciplinaMatricula);
        Task<IDisciplinaMatricula> ValidarDisciplinaMatriculaAsync(int idDisciplina, int idMatricula);
    }
}
