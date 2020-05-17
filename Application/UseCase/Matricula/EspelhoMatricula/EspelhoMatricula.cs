using Domain.Models.Matricula;
using Domain.Service.Matricula;
using System;
using System.Threading.Tasks;

namespace Application.UseCase.Matricula.EspelhoMatricula
{
    public class EspelhoMatricula : IEspelhoMatricula
    {
        public EspelhoMatricula(IMatriculaService matriculaService)
        {
            this.matriculaService = matriculaService 
                ?? throw new ArgumentNullException(nameof(matriculaService));
        }

        private readonly IMatriculaService matriculaService;
        public async Task<IMatricula> EspelhoMatriculaAsync(int IdAluno)
        {
            return await matriculaService.EspelhoMatriculaAsync(IdAluno);
        }
    }
}
