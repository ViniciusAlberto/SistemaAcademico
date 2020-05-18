using AutoMapper;
using Domain.Models.Aluno;
using Domain.Models.DisciplinaMatricula;
using Domain.Models.Matricula;
using Domain.Repository;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        public Task<int> ConsultaQuantidadeMatriculasTurmaDisciplinaAsync(int idTurmaDisciplina) => Task.FromResult(10);

        public Task<IMatricula> ConsultarMatriculaAsync(int idMatricula)
        {
            throw new NotImplementedException();
        }

        public Task<IMatricula> EspelhoMatriculaAsync(int idAluno)
        {

            IMatricula matricula = DataFake.DataFake.matriculas().Where(x => x.Aluno.IdAluno == idAluno).FirstOrDefault();

            matricula.DisciplinaMatricula = new List<IDisciplinaMatricula>(DataFake.DataFake.disciplinaMatriculas().Where(x => x.Matricula.IdMatricula == matricula.IdMatricula).ToList());
            

            return Task.FromResult(matricula);

        }

        public Task<int> RealizaMatriculaAsync(IMatricula matricula)
        {
            return Task.FromResult(10154);
        }
    }
}


