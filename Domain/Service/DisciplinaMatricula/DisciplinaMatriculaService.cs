using Domain.Models.DisciplinaMatricula;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.DisciplinaMatricula
{
    public class DisciplinaMatriculaService :IDisciplinaMatriculaService
    {
        private readonly IDisciplinaMatriculaRepository disciplinaMatriculaRepository;

        public DisciplinaMatriculaService(IDisciplinaMatriculaRepository disciplinaMatriculaRepository)
        {
            this.disciplinaMatriculaRepository = disciplinaMatriculaRepository
                ?? throw new ArgumentNullException(nameof(disciplinaMatriculaRepository));
        }

        public async Task<bool> CancelamentoMatricula(IDisciplinaMatricula disciplinaMatricula)
        {
           return await disciplinaMatriculaRepository.CancelamentoMatricula(disciplinaMatricula);
        }
    }
}
