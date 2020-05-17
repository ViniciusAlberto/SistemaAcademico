using Domain.Models.Matricula;
using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        public Task<int> ConsultaQuantidadeMatriculasTurmaDisciplinaAsync(int idTurmaDisciplina)
        {
            return Task.FromResult(10);
        }

        public Task<IMatricula> ConsultarMatriculaAsync(int idMatricula)
        {
            throw new NotImplementedException();
        }

        public Task<IMatricula> EspelhoMatriculaAsync(int idAluno)
        {
            throw new NotImplementedException();
        }

        public Task<int> RealizaMatriculaAsync(IMatricula matricula)
        {
            return Task.FromResult(10154);
        }
    }
}
