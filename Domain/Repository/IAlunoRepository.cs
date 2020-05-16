using Domain.Models.Aluno;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IAlunoRepository
    {
        /// <summary>
        /// Realiza o cadastro de um aluno.
        /// </summary>
        /// <param name="aluno"></param>
        /// <returns>Retorna o identificador do aluno.</returns>
        Task<int> CadastraAlunoAsync(IAluno aluno);
    }
}
