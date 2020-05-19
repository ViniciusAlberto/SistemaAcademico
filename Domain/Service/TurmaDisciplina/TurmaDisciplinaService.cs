using Domain.Service.Disciplina;
using Domain.Service.Matricula;
using System;
using System.Threading.Tasks;

namespace Domain.Service.TurmaDisciplina
{
    public class TurmaDisciplinaService : ITurmaDisciplinaService
    {
        private readonly IDisciplinaService disciplinaService;
        private readonly IMatriculaService matriculaService;

        public TurmaDisciplinaService(IDisciplinaService disciplinaService,
            IMatriculaService matriculaService)
        {
            this.disciplinaService = disciplinaService 
                ?? throw new ArgumentNullException(nameof(disciplinaService));

            this.matriculaService = matriculaService 
                ?? throw new ArgumentNullException(nameof(matriculaService));
        }

        public async Task<bool> ValidaDisponibilidadeTurmaDisciplinaAsync(int idDisciplina)
        {
            int quantidadeVagasDisciplina = await disciplinaService.ConsultaVagasDisciplina(idDisciplina);

            int quantidadeMatriculados = await matriculaService.ConsultaQuantidadeMatriculasTurmaDisciplinaAsync(idDisciplina);

            if(quantidadeVagasDisciplina > quantidadeMatriculados)
            {
                return true;
            }
            else
            {
                return false;// Retornar exception indicando que não há vagas disponíveis
            }
        }

        public Task<int> ConsultaDisciplinaPorIdTurmaDisciplinaAsync(int idTurmaDisciplina)
        {
            return Task.FromResult(1);
        }

    
    }
}
