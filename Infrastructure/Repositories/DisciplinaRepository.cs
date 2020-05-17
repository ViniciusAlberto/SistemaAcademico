using Domain.Models.Disciplina;
using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        public Task<IDisciplina> ConsultarDisciplinaAsync(int idDisciplina)
        {
            throw new NotImplementedException();
        }

        public Task<int> ConsultaVagasDisciplina(int idDisciplina)
        {
            return Task.FromResult(1000);
        }

        public Task<IDisciplina> ListarDisciplinasAsync(int idTurma)
        {
            throw new NotImplementedException();
        }
    }
}
