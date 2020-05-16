using System.Threading.Tasks;

namespace Application.UseCase.Matricula
{
    public interface ICadastroMatricula
    {
        Task<int> RealizaMatriculaAsync(MatriculaEntrada matriculaEntrada);
    }
}
