using Domain.Models.Disciplina;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        public Task<IDisciplina> ConsultarDisciplinaAsync(int idDisciplina)
        {
            throw new NotImplementedException();
        }

        public Task<int> ConsultaVagasDisciplina(int idDisciplina)
        {
            return Task.FromResult(1000);
        }

        public Task<IEnumerable<IDisciplina>> ListarDisciplinasAsync(int idTurma)
        {
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
                    IdDisciplina = 2,
                    Nome = "Lógica de programação"
                }
            };

            return Task.FromResult(disciplinas);
        }
    }
}
