using Domain.Models.Curso;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Disciplina
{
   public  interface IDisciplina
    {
         int idDisciplina { get; set; }

         string Nome { get; set; }

        int CargaHoraria { get; set; }

        int Capacidade { get; set; }


    }
}
