using Domain.Models.Aluno;
using Domain.Models.DisciplinaMatricula;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCase.Matricula.EspelhoMatricula
{
    public class EspelhoMatriculaSaida
    {
        public int IdMatricula { get; set; }
        public IAluno Aluno { get; set; }
        public DateTime DataMatricula { get; set; }
        public List<ITurmaDisciplina> TurmaDisciplinas { get; set; }
        public List<IDisciplinaMatricula> DisciplinaMatricula { get; set; }
    }
}
