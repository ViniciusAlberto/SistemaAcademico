using Domain.Models.Disciplina;
using Domain.Models.Matricula;

namespace Domain.Models.DisciplinaMatricula
{
    public class DisciplinaMatricula : IDisciplinaMatricula
    {
        public IDisciplina Disciplina { get; set; }
        public IMatricula Matricula { get; set; }

        public Situcao Situacao { get; set; }
    }
}
