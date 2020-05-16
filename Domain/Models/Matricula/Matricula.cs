using Domain.Models.Aluno;
using Domain.Models.Disciplina;
using Domain.Models.DisciplinaTurma;
using System;
using System.Collections.Generic;

namespace Domain.Models.Matricula
{
    public class Matricula : IMatricula
    {
        public int IdMatricula { get; set; }
        public IAluno Aluno { get; set; }
        public List<IDisciplina> Disciplinas { get; set; }
        public List<ITurmaDisciplina> TurmaDisciplinas { get; set; }
        public DateTime DataMatricula { get; set; }
    }
}
