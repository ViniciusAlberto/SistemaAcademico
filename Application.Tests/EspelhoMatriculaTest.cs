using Application.UseCase.Matricula.EspelhoMatricula;
using AutoMapper;
using Domain.Models.Aluno;
using Domain.Models.Aluno.Enum;
using Domain.Models.Matricula;
using Domain.Service.Matricula;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Application.Tests
{
    public class EspelhoMatriculaTest
    {
        private readonly Mock<IMatriculaService> matriculaService;
        private readonly EspelhoMatricula espelhoMatricula;

        public EspelhoMatriculaTest()
        {
            var mapp = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IMatricula, EspelhoMatriculaSaida>();
            });

            matriculaService = new Mock<IMatriculaService>();
            espelhoMatricula = new EspelhoMatricula(matriculaService.Object, mapp.CreateMapper());
        }

        [Fact]
        public async Task EspelhoMatricula_Teste()
        {
            int idAluno = 221213;

            var espelhoMatriculaSaida = new EspelhoMatriculaSaida
            {
                IdMatricula = 1542,
                Aluno = new Aluno
                {
                    CPF = "01234567890",
                    Sexo = Sexo.Feminino,
                    Nome = "Valdirene"
                }
            };

            var matricula = new Matricula
            {
                IdMatricula = 1542,
                Aluno = new Aluno
                {
                    CPF = "01234567890",
                    Sexo = Sexo.Feminino,
                    Nome = "Valdirene"
                }
            };

            matriculaService.Setup(m => m.EspelhoMatriculaAsync(It.IsAny<int>()))
                .ReturnsAsync(matricula);

            var retorno = await espelhoMatricula.EspelhoMatriculaAsync(idAluno);

            Assert.Equal(espelhoMatriculaSaida.IdMatricula, retorno.IdMatricula);
            Assert.Equal(espelhoMatriculaSaida.Aluno.Nome, retorno.Aluno.Nome);
            Assert.Equal(espelhoMatriculaSaida.Aluno.Sexo, retorno.Aluno.Sexo);
            Assert.Equal(espelhoMatriculaSaida.Aluno.Nome, retorno.Aluno.Nome);
        }
    }
}
