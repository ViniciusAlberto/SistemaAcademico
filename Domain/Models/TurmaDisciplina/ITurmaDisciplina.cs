using Domain.Models.Disciplina;
using Domain.Models.Turma;

namespace Domain.Models.DisciplinaTurma
{
    public interface ITurmaDisciplina
    {
        IDisciplina Disciplina { get; set; }

        ITurma Turma { get; set; }
    }
}
