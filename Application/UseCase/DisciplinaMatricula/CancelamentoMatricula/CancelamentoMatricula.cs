using Domain.Models.Disciplina;
using Domain.Models.Matricula;
using Domain.Service.Disciplina;
using Domain.Service.DisciplinaMatricula;
using Domain.Service.Matricula;
using System;
using System.Threading.Tasks;


namespace Application.UseCase.DisciplinaMatricula.CancelamentoMatricula
{
    public class CancelamentoMatricula : ICancelamentoMatricula
    {
        public CancelamentoMatricula(IDisciplinaMatriculaService disciplinaMatriculaService,
            IMatriculaService matriculaService, IDisciplinaService disciplinaService)
        {
            this.disciplinaMatriculaService = disciplinaMatriculaService 
                ?? throw new ArgumentNullException(nameof(disciplinaMatriculaService));
            this.matriculaService = matriculaService 
                ?? throw new ArgumentNullException(nameof(matriculaService));
            this.disciplinaService = disciplinaService 
                ?? throw new ArgumentNullException(nameof(disciplinaService));
        }

        private readonly IDisciplinaMatriculaService disciplinaMatriculaService;
        private readonly IMatriculaService matriculaService;
        private readonly IDisciplinaService disciplinaService;

        public async Task<bool> CancelarDisciplinaAsync(CancelamentoMatriculaEntrada cancelamentoMatriculaEntrada)
        {

            IDisciplina disciplina = await disciplinaService.ConsultarDisciplinaAsync(cancelamentoMatriculaEntrada.IdDisciplina);
            IMatricula  matricula = await matriculaService.ConsultarMatriculaAsync(cancelamentoMatriculaEntrada.IdMatricula);

            if (disciplina != null || matricula != null)
            {
                return false;
            }

            var disciplinaMatricula = new Domain.Models.DisciplinaMatricula.DisciplinaMatricula(){
                Disciplina = disciplina,
                Matricula = matricula,
                Situacao = Domain.Models.DisciplinaMatricula.Situcao.Cancelado
            };

            return await disciplinaMatriculaService.CancelamentoMatricula(disciplinaMatricula);
        }
    }
}
