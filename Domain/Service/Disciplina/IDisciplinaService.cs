using Domain.Models.Disciplina;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Service.Disciplina
{
    public interface IDisciplinaService
    {
        Task<int> ConsultaVagasDisciplina(int idDisciplina);

        Task<IEnumerable<IDisciplina>> ListarDisciplinasAsync(int IdTurma);   
        Task<IDisciplina> ConsultarDisciplinaAsync(int idDisciplina);
    }
}
