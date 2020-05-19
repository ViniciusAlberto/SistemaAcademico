using Domain.Service.Matricula;
using Domain.Service.TurmaDisciplina;
using System;
using System.Threading.Tasks;

namespace Application.UseCase.Matricula
{
    public class CadastroMatricula : ICadastroMatricula
    {
        private readonly IMatriculaService matriculaService;
        private readonly ITurmaDisciplinaService turmaDisciplinaService;

        public CadastroMatricula(IMatriculaService matriculaService,
            ITurmaDisciplinaService turmaDisciplinaService)
        {
            this.matriculaService = matriculaService
                ?? throw new ArgumentNullException(nameof(matriculaService));

            this.turmaDisciplinaService = turmaDisciplinaService
                ?? throw new ArgumentNullException(nameof(turmaDisciplinaService));
        }

        public async Task<int> RealizaMatriculaAsync(MatriculaEntrada matriculaEntrada)
        {
            foreach (var idDisciplina in matriculaEntrada.Disiplinas)
            {
                await turmaDisciplinaService
                    .ValidaDisponibilidadeTurmaDisciplinaAsync(idDisciplina);
            }

            //TODO: Adicionar mapeamento entre os objetos MatriculaEntrada e Matricula
            return await matriculaService.RealizaMatriculaAsync(null);
        }
    }
}
