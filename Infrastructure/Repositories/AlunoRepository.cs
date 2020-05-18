using Domain.Models.Aluno;
using Domain.Repository;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        public Task<int> CadastraAlunoAsync(IAluno aluno)
        {
            return Task.FromResult(new Random().Next(1, 5));
        }
    }
}
