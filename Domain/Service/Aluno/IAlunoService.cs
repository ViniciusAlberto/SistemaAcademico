using Domain.Models.Aluno;
using System.Threading.Tasks;

namespace Domain.Service.Aluno
{
    public interface IAlunoService
    {
        /// <summary>
        /// Realiza o cadastro de um aluno.
        /// </summary>
        /// <param name="aluno"></param>
        /// <returns>Retorna o identificador do aluno.</returns>
        Task<int> CadastraAlunoAsync(IAluno aluno);

        Task<IAluno> ConsultarAlunoPorCpfAsync(string cpf);
    }
}
