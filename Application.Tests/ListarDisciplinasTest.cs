using Application.UseCase.Disciplina;
using Application.UseCase.Disciplina.ListarDisciplina;
using AutoMapper;
using Domain.Models.Disciplina;
using Domain.Service.Disciplina;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Application.Tests
{
    public class ListarDisciplinasTest
    {
        private readonly IListarDisciplinas listarDisciplinas;
        private readonly Mock<IDisciplinaService> disciplinaService;

        public ListarDisciplinasTest()
        {
            var mapp = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IDisciplina, ListarDiciplinasSaida>();
            });

            disciplinaService = new Mock<IDisciplinaService>();
            listarDisciplinas = new ListarDisciplinas(disciplinaService.Object, mapp.CreateMapper());
        }

        [Fact]
        public async Task ListarDisciplinas_TesteAsync()
        {
            var disciplinasSaida = new List<ListarDiciplinasSaida>()
            {
                new ListarDiciplinasSaida
                {
                    CargaHoraria = 48,
                    IdDisciplina = 1,
                    Nome = "Front End"
                },
                new ListarDiciplinasSaida
                {
                    CargaHoraria = 32,
                    IdDisciplina = 2,
                    Nome = "Gestão de projetos"
                },
                new ListarDiciplinasSaida
                {
                    CargaHoraria = 32,
                    IdDisciplina = 3,
                    Nome = "Lógica de programação"
                }
            };

            IEnumerable<IDisciplina> disciplinas = new List<IDisciplina>()
            {
                new Disciplina
                {
                    Capacidade = 10,
                    CargaHoraria = 48,
                    IdDisciplina = 1,
                    Nome = "Front End"
                },
                new Disciplina
                {
                    Capacidade = 12,
                    CargaHoraria = 32,
                    IdDisciplina = 2,
                    Nome = "Gestão de projetos"
                },
                new Disciplina
                {
                    Capacidade = 5,
                    CargaHoraria = 32,
                    IdDisciplina = 3,
                    Nome = "Lógica de programação"
                }
            };

            disciplinaService.Setup(d => d.ListarDisciplinasAsync(It.IsAny<int>()))
                .ReturnsAsync(disciplinas);

            var retorno = await listarDisciplinas.ListarDisciplinasAsync(It.IsAny<int>());

            Assert.Collection(disciplinasSaida, item1 =>
            {
                Assert.Equal(item1.Nome, retorno.ToList()[0].Nome);
                Assert.Equal(item1.IdDisciplina, retorno.ToList()[0].IdDisciplina);
                Assert.Equal(item1.CargaHoraria, retorno.ToList()[0].CargaHoraria);
            },
            item2=>
            {
                Assert.Equal(item2.Nome, retorno.ToList()[1].Nome);
                Assert.Equal(item2.IdDisciplina, retorno.ToList()[1].IdDisciplina);
                Assert.Equal(item2.CargaHoraria, retorno.ToList()[1].CargaHoraria);
            },
            item3 =>
            {
                Assert.Equal(item3.Nome, retorno.ToList()[2].Nome);
                Assert.Equal(item3.IdDisciplina, retorno.ToList()[2].IdDisciplina);
                Assert.Equal(item3.CargaHoraria, retorno.ToList()[2].CargaHoraria);
            });
        }
    }
}
