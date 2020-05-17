using Domain.Models.Matricula;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IMatriculaRepository
    {
        Task<int> ConsultaQuantidadeMatriculasTurmaDisciplinaAsync(int idTurmaDisciplina);
        Task<int> RealizaMatriculaAsync(IMatricula matricula);
        Task<IMatricula> EspelhoMatricula(int idAluno);
    }
}
