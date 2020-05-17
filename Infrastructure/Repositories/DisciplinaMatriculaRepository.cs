using Domain.Models.DisciplinaMatricula;
using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class DisciplinaMatriculaRepository : IDisciplinaMatriculaRepository
    {
        public Task<bool> CancelamentoMatricula(IDisciplinaMatricula disciplinaMatricula)
        {
            throw new NotImplementedException();
        }
    }
}
