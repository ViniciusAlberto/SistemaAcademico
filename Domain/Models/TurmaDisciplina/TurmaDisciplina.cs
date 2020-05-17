using Domain.Models.Disciplina;
using Domain.Models.DisciplinaMatricula;
using Domain.Models.Turma;

namespace Domain.Models.DisciplinaTurma
{
    public class DisciplinaMatricula : ITurmaDisciplina
    {
        public IDisciplina Disciplina { get; set; }
        public ITurma Turma { get; set; }
    }
}
