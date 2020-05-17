
using Domain.Models.DisciplinaMatricula;
using Domain.Service.DisciplinaMatricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.DisciplinaMatricula.CancelamentoMatricula
{
    public class CancelamentoMatricula : ICancelamentoMatricula
    {
        private readonly IDisciplinaMatriculaService disciplinaMatriculaService;
     
        public async Task<bool> CancelarDisciplinaAsync(CancelamentoMatriculaEntrada cancelamentoMatriculaEntrada)
        {

            //Implementar código 

            return await disciplinaMatriculaService.CancelamentoMatricula( new Domain.Models.DisciplinaMatricula.DisciplinaMatricula());
        }
    }
}
