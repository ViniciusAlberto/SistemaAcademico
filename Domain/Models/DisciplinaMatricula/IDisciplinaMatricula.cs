using Domain.Models.Disciplina;
using Domain.Models.DisciplinaMatricula;
using Domain.Models.Matricula;
using Domain.Models.Turma;
using System.Threading.Tasks;

namespace Domain.Models.DisciplinaMatricula
{
    public interface IDisciplinaMatricula
    {
        IDisciplina Disciplina { get; set; }

        IMatricula Matricula { get; set; }

        Situcao Situacao { get; set; }

       
    }
}
