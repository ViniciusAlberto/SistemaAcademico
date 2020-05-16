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

        public Task<int> RealizaMatriculaAsync(IMatricula matricula)
        {
            return Task.FromResult(10154);
        }
    }
}
