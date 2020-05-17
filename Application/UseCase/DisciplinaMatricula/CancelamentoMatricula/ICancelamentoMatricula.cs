using Application.UseCase.Matricula.EspelhoMatricula;
using Domain.Models.Matricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.DisciplinaMatricula.CancelamentoMatricula
{
    public interface ICancelamentoMatricula
    {
        Task<bool> CancelarDisciplinaAsync(CancelamentoMatriculaEntrada cancelamentoMatriculaEntrada);
    }
}
