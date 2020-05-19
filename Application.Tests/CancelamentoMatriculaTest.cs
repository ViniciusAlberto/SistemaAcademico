using Application.UseCase.DisciplinaMatricula.CancelamentoMatricula;
using Domain.Models.DisciplinaMatricula;
using Domain.Service.DisciplinaMatricula;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Application.Tests
{
    public class CancelamentoMatriculaTest
    {
        private readonly Mock<IDisciplinaMatriculaService> disciplinaMatriculaService;
        private readonly CancelamentoMatricula cancelamentoMatricula;
        public CancelamentoMatriculaTest()
        {
            disciplinaMatriculaService = new Mock<IDisciplinaMatriculaService>();
            cancelamentoMatricula = new CancelamentoMatricula(disciplinaMatriculaService.Object);
        }

        [Fact]
        public async Task CancelamentoMatricula_MatriculaExistente()
        {
            var cancelamentoMatriculaEntrada = new CancelamentoMatriculaEntrada
            {
                IdDisciplina = 1,
                IdMatricula = 5541
            };

            var disciplinaMatricula = new DisciplinaMatricula
            {
                Situacao = Situcao.Matriculado
            };

            disciplinaMatriculaService.Setup(d => d.ValidarDisciplinaMatriculaAsync(It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync(disciplinaMatricula);

            disciplinaMatriculaService.Setup(d => d.CancelamentoMatriculaAsync(It.IsAny<DisciplinaMatricula>()))
                .ReturnsAsync(true);

            var retorno = await cancelamentoMatricula.CancelarDisciplinaAsync(cancelamentoMatriculaEntrada);

            Assert.True(retorno);
        }

        [Fact]
        public async Task CancelamentoMatricula_MatriculaJaCancelada()
        {
            var cancelamentoMatriculaEntrada = new CancelamentoMatriculaEntrada
            {
                IdDisciplina = 1,
                IdMatricula = 5541
            };

            var disciplinaMatricula = new DisciplinaMatricula
            {
                Situacao = Situcao.Cancelado
            };

            disciplinaMatriculaService.Setup(d => d.ValidarDisciplinaMatriculaAsync(It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync(disciplinaMatricula);

            var retorno = await cancelamentoMatricula.CancelarDisciplinaAsync(cancelamentoMatriculaEntrada);

            Assert.False(retorno);
        }

        [Fact]
        public async Task CancelamentoMatricula_MatriculaInexistente()
        {
            var cancelamentoMatriculaEntrada = new CancelamentoMatriculaEntrada
            {
                IdDisciplina = 1,
                IdMatricula = 5541
            };

            disciplinaMatriculaService.Setup(d => d.ValidarDisciplinaMatriculaAsync(It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync((DisciplinaMatricula)null);

            var retorno = await cancelamentoMatricula.CancelarDisciplinaAsync(cancelamentoMatriculaEntrada);

            Assert.False(retorno);
        }
    }
}
