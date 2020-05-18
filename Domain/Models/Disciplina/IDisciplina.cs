using Domain.Models.Turma;
using System;

namespace Domain.Models.Disciplina
{
    public interface IDisciplina
    {
        int IdDisciplina { get; set; }

        string Nome { get; set; }

        int CargaHoraria { get; set; }

        int Capacidade { get; set; }
      

        DateTime DataInicioTurma { get; set; }

        DateTime DataTerminoTurma { get; set; }

        DateTime DataCadastro { get; set; }
    }
}
