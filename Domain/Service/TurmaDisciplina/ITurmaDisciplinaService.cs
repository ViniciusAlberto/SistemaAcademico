using System.Threading.Tasks;

namespace Domain.Service.TurmaDisciplina
{
    public interface ITurmaDisciplinaService
    {
        Task<bool> ValidaDisponibilidadeTurmaDisciplinaAsync(int idTurmaDisciplina);

        Task<int> ConsultaDisciplinaPorIdTurmaDisciplinaAsync(int idTurmaDisciplina);
    }
}
