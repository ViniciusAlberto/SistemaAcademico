using Domain.Models.DisciplinaMatricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.DisciplinaMatricula
{
    public interface IDisciplinaMatriculaService
    {
        Task<bool> CancelamentoMatricula(IDisciplinaMatricula disciplinaMatricula);
    }
}
