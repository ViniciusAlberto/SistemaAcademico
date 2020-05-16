using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Models.Turma
{
    public interface ITurma
    {
        int IdTurma { get; set; }

        string Oferta { get; set; }

        DateTime DataInicioTurma { get; set; }

        DateTime DataTerminoTurma { get; set; }

        DateTime DataCadastro { get; set; }
    }
}
