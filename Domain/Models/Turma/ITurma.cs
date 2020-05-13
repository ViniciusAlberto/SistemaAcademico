using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Turma
{
   public  interface ITurma
    {
         int idTurma { get; set; }

        string Oferta { get; set; }
    }
}
