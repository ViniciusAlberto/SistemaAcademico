using Application.UseCase.Disciplina.ListarDisciplina;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCase.Disciplina
{
    public  interface IListarDisciplinas
    {
        Task<IEnumerable<ListarDiciplinasSaida>> ListarDisciplinasAsync(int IdTurma);
    }
}
