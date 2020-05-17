using Application.UseCase.Disciplina.ListarDisciplina;
using Domain.Service.Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.UseCase.Disciplina
{
    public class ListarDisciplinas : IListarDisciplinas
    {
        private readonly IDisciplinaService disciplinaService;

        public ListarDisciplinas(IDisciplinaService disciplinaService)
        {
            this.disciplinaService = disciplinaService 
                ?? throw new ArgumentNullException(nameof(disciplinaService));
        }

        public async Task<IEnumerable<ListarDiciplinasSaida>> ListarDisciplinasAsync(int IdTurma)
        {
            var disciplinas = await disciplinaService.ListarDisciplinasAsync(IdTurma);

            return Enumerable.Empty<ListarDiciplinasSaida>();
        }
    }
}
