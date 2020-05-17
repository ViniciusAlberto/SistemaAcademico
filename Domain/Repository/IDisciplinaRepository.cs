using Domain.Models.Disciplina;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IDisciplinaRepository
    {
        Task<int> ConsultaVagasDisciplina(int idDisciplina);

        Task<IDisciplina> ConsultarDisciplinaAsync(int idDisciplina);

        Task<IEnumerable<IDisciplina>> ListarDisciplinasAsync(int idTurma);
    }
}
