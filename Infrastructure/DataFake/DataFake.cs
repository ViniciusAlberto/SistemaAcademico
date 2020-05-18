using Domain.Models.Aluno;
using Domain.Models.Disciplina;
using Domain.Models.DisciplinaMatricula;
using Domain.Models.Matricula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository.DataFake
{
    public class DataFake
    {
        public static List<Aluno> alunos()
        {
            return new List<Aluno>() {
             new Aluno()
            {
                Nome = "Jose",
                CPF = "12222234567",
                DataNascimento = DateTime.Now.AddYears(-20),
                IdAluno = 1,
                Sexo = Domain.Models.Aluno.Enum.Sexo.Masculino
            },

            new Aluno()
            {
                Nome = "Maria",
                CPF = "65891339125",
                DataNascimento = DateTime.Now.AddYears(-21),
                IdAluno = 2,
                Sexo = Domain.Models.Aluno.Enum.Sexo.Feminino
            },

            new Aluno()
            {
                Nome = "Joao",
                CPF = "12516120678",
                DataNascimento = DateTime.Now.AddYears(-22),
                IdAluno = 4,
                Sexo = Domain.Models.Aluno.Enum.Sexo.Masculino
            },

            new Aluno()
            {
                Nome = "Carol",
                CPF = "25569874165",
                DataNascimento = DateTime.Now.AddYears(-23),
                IdAluno = 3,
                Sexo = Domain.Models.Aluno.Enum.Sexo.Feminino
            }
        };

        }

        public static IEnumerable<Disciplina> disciplinas ()
        {

            return new List<Disciplina>()
            {
                new Disciplina
                {
                    Capacidade = 10,
                    CargaHoraria = 48,
                    IdDisciplina = 1,
                    Nome = "Front End"
                },
                new Disciplina
                {
                    Capacidade = 12,
                    CargaHoraria = 32,
                    IdDisciplina = 2,
                    Nome = "Gestão de projetos"
                },
                new Disciplina
                {
                    Capacidade = 5,
                    CargaHoraria = 32,
                    IdDisciplina = 2,
                    Nome = "Lógica de programação"
                }
            };

        }

        public static IEnumerable<Matricula> matriculas()
        {

            return new List<Matricula>()
            {
                new Matricula
                {
                    Aluno = alunos().ElementAt(0),
                    DataMatricula = DateTime.Now.AddDays(-5),
                    IdMatricula = 1,
                    

                   
                },
                new Matricula
                {
                    Aluno = alunos().ElementAt(1),
                    DataMatricula = DateTime.Now.AddDays(-4),
                    IdMatricula = 2

                },
               new Matricula
                {
                    Aluno = alunos().ElementAt(2),
                    DataMatricula = DateTime.Now.AddDays(-3),
                    IdMatricula = 3

                },
               new Matricula
                {
                    Aluno = alunos().ElementAt(3),
                    DataMatricula = DateTime.Now.AddDays(-2),
                    IdMatricula = 4

                },
            };

        }

        public static IEnumerable<DisciplinaMatricula> disciplinaMatriculas()
        {
            return new List<DisciplinaMatricula>()
            {
                new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(0),
                    Matricula = matriculas().ElementAt(0),
                    Situacao = Situcao.Matriculado
                },
                 new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(1),
                    Matricula = matriculas().ElementAt(0),
                    Situacao = Situcao.Matriculado
                },
                  new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(2),
                    Matricula = matriculas().ElementAt(0),
                    Situacao = Situcao.Matriculado
                },
                   new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(1),
                    Matricula = matriculas().ElementAt(1),
                    Situacao = Situcao.Matriculado
                },
                    new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(1),
                    Matricula = matriculas().ElementAt(2),
                    Situacao = Situcao.Matriculado
                },
                     new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(2),
                    Matricula = matriculas().ElementAt(2),
                    Situacao = Situcao.Matriculado
                },
                      new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(0),
                    Matricula = matriculas().ElementAt(3),
                    Situacao = Situcao.Cancelado
                },
                       new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(0),
                    Matricula = matriculas().ElementAt(3),
                    Situacao = Situcao.Matriculado
                },
                        new DisciplinaMatricula()
                {
                    Disciplina = disciplinas().ElementAt(2),
                    Matricula = matriculas().ElementAt(3),
                    Situacao = Situcao.Matriculado
                }

            };
        }
    }
}
