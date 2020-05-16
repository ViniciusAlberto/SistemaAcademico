using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IDisciplinaRepository
    {
        Task<int> ConsultaVagasDisciplina(int idDisciplina);
    }
}
