using Domain.Models.Aluno;
using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Domain.Service.Aluno
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            this.alunoRepository = alunoRepository 
                ?? throw new ArgumentNullException(nameof(alunoRepository));
        }

        public async Task<int> CadastraAlunoAsync(IAluno aluno)
        {
            return await alunoRepository.CadastraAlunoAsync(aluno);
        }

        public Task<IAluno> ConsultarAlunoPorCpfAsync(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
