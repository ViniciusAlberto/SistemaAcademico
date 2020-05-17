using Domain.Models.Aluno;
using Domain.Service.Aluno;
using System.Threading.Tasks;

namespace Application.UseCase.Aluno
{
    public class CadastroAluno : ICadastroAluno
    {
        private readonly IAlunoService alunoService;

        public CadastroAluno(IAlunoService alunoService)
        {
            this.alunoService = alunoService 
                ?? throw new System.ArgumentNullException(nameof(alunoService));
        }
        public async Task CadastraAlunoAsync(AlunoEntrada aluno)
        {
            IAluno alunoModel = await alunoService.ConsultarAlunoPorCpfAsync(aluno.CPF);

            if(alunoModel != null)
            {
                return;
            }

            //alunoModel = new Aluno(alunno); Falta implementar

            await alunoService.CadastraAlunoAsync(alunoModel);
        }
    }
}
