using Domain.Models.Disciplina;
using Domain.Models.Turma;

namespace Domain.Models.DisciplinaTurma
{
    public class TurmaDisciplina : ITurmaDisciplina
    {
        public IDisciplina Disciplina { get; set; }
        public ITurma Turma { get; set; }
    }
}
