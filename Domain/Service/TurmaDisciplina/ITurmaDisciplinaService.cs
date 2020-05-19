using System.Threading.Tasks;

namespace Domain.Service.TurmaDisciplina
{
    public interface ITurmaDisciplinaService
    {
        Task<bool> ValidaDisponibilidadeTurmaDisciplinaAsync(int idDisciplina);

        Task<int> ConsultaDisciplinaPorIdTurmaDisciplinaAsync(int idTurmaDisciplina);
    }
}
