using System;

namespace Domain.Models.Turma
{
    public class Turma : ITurma
    {
        public int IdTurma { get; set; }
        public string Oferta { get; set; }
        public DateTime DataInicioTurma { get; set; }
        public DateTime DataTerminoTurma { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
