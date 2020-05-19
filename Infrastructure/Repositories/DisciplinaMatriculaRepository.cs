using Domain.Models.Disciplina;
using Domain.Models.DisciplinaMatricula;
using Domain.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class DisciplinaMatriculaRepository : IDisciplinaMatriculaRepository
    {
      
        public Task<bool> CancelamentoMatriculaAsync(IDisciplinaMatricula disciplinaMatricula)
        {
            return Task.FromResult(true);
        }

        public Task<IDisciplinaMatricula> ValidarDisciplinaMatriculaAsync(int idDisciplina, int idMatricula)
        {
           IDisciplinaMatricula disciplinaMatricula =  DataFake.DataFake.disciplinaMatriculas().Where(x=> x.Disciplina.IdDisciplina == idDisciplina && x.Matricula.IdMatricula == idMatricula).FirstOrDefault();

            return Task.FromResult(disciplinaMatricula);
        }
    }
}
