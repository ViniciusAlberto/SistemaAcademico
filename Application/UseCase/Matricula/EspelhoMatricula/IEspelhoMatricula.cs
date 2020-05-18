using Domain.Models.Matricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Matricula.EspelhoMatricula
{
    public interface IEspelhoMatricula
    {
        Task<EspelhoMatriculaSaida> EspelhoMatriculaAsync(int IdAluno);
    }
}
