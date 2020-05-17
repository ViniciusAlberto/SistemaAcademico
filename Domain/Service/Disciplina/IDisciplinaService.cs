using Domain.Models.Disciplina;
using System.Threading.Tasks;

namespace Domain.Service.Disciplina
{
    public interface IDisciplinaService
    {
        Task<int> ConsultaVagasDisciplina(int idDisciplina);

        Task<IDisciplina> ListarDisciplinas(int IdTurma);
    }
}
