using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Domain.Service.Disciplina
{
    public class DisciplinaService : IDisciplinaService
    {
        private readonly IDisciplinaRepository disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            this.disciplinaRepository = disciplinaRepository 
                ?? throw new ArgumentNullException(nameof(disciplinaRepository));
        }
        public async Task<int> ConsultaVagasDisciplina(int idDisciplina)
        {
            return await disciplinaRepository.ConsultaVagasDisciplina(idDisciplina);
        }
    }
}
