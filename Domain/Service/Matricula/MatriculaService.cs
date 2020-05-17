using Domain.Models.Matricula;
using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Domain.Service.Matricula
{
    public class MatriculaService : IMatriculaService
    {
        private readonly IMatriculaRepository matriculaRepository;

        public MatriculaService(IMatriculaRepository matriculaRepository)
        {
            this.matriculaRepository = matriculaRepository 
                ?? throw new ArgumentNullException(nameof(matriculaRepository));
        }
        public async Task<int> ConsultaQuantidadeMatriculasTurmaDisciplinaAsync(int idTurmaDisciplina)
        {
            return await matriculaRepository.ConsultaQuantidadeMatriculasTurmaDisciplinaAsync(idTurmaDisciplina);
        }

        public async Task<int> RealizaMatriculaAsync(IMatricula matricula)
        {
            return await matriculaRepository.RealizaMatriculaAsync(matricula);
        }

        public async Task<IMatricula> EspelhoMatricula(int IdAluno)
        {
            return await matriculaRepository.EspelhoMatricula(IdAluno);
        }
    }
}
