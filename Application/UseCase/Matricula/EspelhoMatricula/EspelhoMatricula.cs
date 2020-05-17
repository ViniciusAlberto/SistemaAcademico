using Domain.Models.Matricula;
using Domain.Service.Matricula;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase.Matricula.EspelhoMatricula
{
    public class EspelhoMatricula : IEspelhoMatricula
    {
        private readonly IMatriculaService matriculaService;
        public async Task<IMatricula> EspelhoMatriculaAsync(int IdAluno)
        {
            return await matriculaService.EspelhoMatricula(IdAluno);
        }
    }
}
