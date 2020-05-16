using System;

namespace Domain.Models.Disciplina
{
    public class Disciplina : IDisciplina
    {
        public int IdDisciplina { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int Capacidade { get; set; }
        public DateTime DataInicioTurma { get; set; }
        public DateTime DataTerminoTurma { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
