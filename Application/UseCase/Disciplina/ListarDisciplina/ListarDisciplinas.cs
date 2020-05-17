using Domain.Models.Disciplina;
using Domain.Service.Disciplina;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Disciplina
{
    class ListarDisciplinas : IListarDisciplinas
    {
        private readonly IDisciplinaService disciplinaService;
        public async Task<IDisciplina> ListarDisciplinasAsync(int IdTurma)
        {
            return await disciplinaService.ListarDisciplinas(IdTurma);
        }
    }
}
