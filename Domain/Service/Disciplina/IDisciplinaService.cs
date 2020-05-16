using System.Threading.Tasks;

namespace Domain.Service.Disciplina
{
    public interface IDisciplinaService
    {
        Task<int> ConsultaVagasDisciplina(int idDisciplina);
    }
}
