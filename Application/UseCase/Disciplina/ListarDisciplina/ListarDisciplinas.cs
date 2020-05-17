using Domain.Models.Disciplina;
using Domain.Service.Disciplina;
using System;
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

        public async Task<IDisciplina> ListarDisciplinasAsync(int IdTurma)
        {
            return await disciplinaService.ListarDisciplinasAsync(IdTurma);
        }
    }
}
