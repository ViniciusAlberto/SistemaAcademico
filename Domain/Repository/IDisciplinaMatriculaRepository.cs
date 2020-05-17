using Domain.Models.DisciplinaMatricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IDisciplinaMatriculaRepository
    {
        Task<bool> CancelamentoMatricula(IDisciplinaMatricula disciplinaMatricula);
    }
}
