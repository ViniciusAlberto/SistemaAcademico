using Domain.Models.Matricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Matricula.EspelhoMatricula
{
    interface IEspelhoMatricula
    {
        Task<IMatricula> EspelhoMatriculaAsync(int IdAluno);
    }
}
