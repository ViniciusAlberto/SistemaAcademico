using Domain.Models.Disciplina;
using Domain.Models.DisciplinaMatricula;
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
        private readonly IDisciplinaMatriculaService disciplinaMatriculaService;
        public CancelamentoMatricula(IDisciplinaMatriculaService disciplinaMatriculaService)
        {
            this.disciplinaMatriculaService = disciplinaMatriculaService 
                ?? throw new ArgumentNullException(nameof(disciplinaMatriculaService));        
        }         

        public async Task<bool> CancelarDisciplinaAsync(CancelamentoMatriculaEntrada cancelamentoMatriculaEntrada)
        {
            IDisciplinaMatricula disciplinaMatricula = await disciplinaMatriculaService.ValidarDisciplinaMatriculaAsync(cancelamentoMatriculaEntrada.IdDisciplina, cancelamentoMatriculaEntrada.IdMatricula);

            if (disciplinaMatricula == null)
                return false;        


            if(disciplinaMatricula.Situacao == Situcao.Cancelado)
                return false;


            disciplinaMatricula.Situacao = Situcao.Cancelado;

            return await disciplinaMatriculaService.CancelamentoMatriculaAsync(disciplinaMatricula);
        }
    }
}
