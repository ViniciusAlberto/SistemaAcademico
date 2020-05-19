using Application.UseCase.Matricula;
using Domain.Models.Aluno.Enum;
using Domain.Models.Matricula;
using Domain.Service.Matricula;
using Domain.Service.TurmaDisciplina;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Application.Tests
{
    public class CadastroMatriculaTest
    {
        private readonly CadastroMatricula cadastroMatricula;
        private readonly Mock<IMatriculaService> matriculaService;
        private readonly Mock<ITurmaDisciplinaService> turmaDisciplinaService;

        public CadastroMatriculaTest()
        {
            matriculaService = new Mock<IMatriculaService>();
            turmaDisciplinaService = new Mock<ITurmaDisciplinaService>();
            cadastroMatricula = new CadastroMatricula(matriculaService.Object, turmaDisciplinaService.Object);
        }

        [Fact]
        public async Task RealizaMatricula_Teste()
        {
            var matriculaEntrada = new MatriculaEntrada
            {
                Cpf = "01234567890",
                Nome = "Fulano de tal",
                Sexo = Sexo.Masculino,
                Disiplinas = new List<int>
                {
                    1, 2, 3
                }
            };

            int identificadorMatricula = 12345;

            turmaDisciplinaService.Setup(t => t.ValidaDisponibilidadeTurmaDisciplinaAsync(It.IsAny<int>()))
                .ReturnsAsync(true);

            matriculaService.Setup(m => m.RealizaMatriculaAsync(It.IsAny<Matricula>()))
                .ReturnsAsync(identificadorMatricula);

            var retorno = await cadastroMatricula.RealizaMatriculaAsync(matriculaEntrada);

            Assert.Equal(identificadorMatricula, retorno);
        }
    }
}
