using Domain.Models.DisciplinaMatricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IDisciplinaMatriculaRepository
    {
       
        Task<bool> CancelamentoMatriculaAsync(IDisciplinaMatricula disciplinaMatricula);
         Task<IDisciplinaMatricula> ValidarDisciplinaMatriculaAsync(int idDisciplina, int idMatricula);
    }
}
