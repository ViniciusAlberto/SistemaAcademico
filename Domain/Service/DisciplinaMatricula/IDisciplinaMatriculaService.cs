using Domain.Models.DisciplinaMatricula;
using System.Threading.Tasks;

namespace Domain.Service.DisciplinaMatricula
{
    public interface IDisciplinaMatriculaService
    {
        Task<bool> CancelamentoMatriculaAsync(IDisciplinaMatricula disciplinaMatricula);
        Task<IDisciplinaMatricula> ValidarDisciplinaMatriculaAsync(int idDisciplina, int idMatricula);
    }
}
