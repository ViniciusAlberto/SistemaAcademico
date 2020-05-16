using Domain.Models.Matricula;
using System.Threading.Tasks;

namespace Domain.Service.Matricula
{
    public interface IMatriculaService
    {
        Task<int> ConsultaQuantidadeMatriculasTurmaDisciplinaAsync(int idTurmaDisciplina);

        Task<int> RealizaMatriculaAsync(IMatricula matricula);
    }
}
