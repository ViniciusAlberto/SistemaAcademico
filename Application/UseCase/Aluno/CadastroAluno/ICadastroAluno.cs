using System.Threading.Tasks;

namespace Application.UseCase.Aluno
{
    public interface ICadastroAluno
    {
        Task CadastraAlunoAsync(AlunoEntrada aluno);
    }
}
