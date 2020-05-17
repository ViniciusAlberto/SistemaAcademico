using Domain.Models.Disciplina;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Disciplina
{
   public  interface IListarDisciplinas
    {
        Task<IDisciplina> ListarDisciplinasAsync(int IdTurma);
    }
}
