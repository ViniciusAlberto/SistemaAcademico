using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        public Task<int> ConsultaVagasDisciplina(int idDisciplina)
        {
            return Task.FromResult(1000);
        }
    }
}
