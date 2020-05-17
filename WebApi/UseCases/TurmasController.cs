using Application.UseCase.Disciplina;
using Application.UseCase.Disciplina.ListarDisciplina;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.UseCases
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmasController : ControllerBase
    {
        private readonly IListarDisciplinas listarDisciplinas;

        public TurmasController(IListarDisciplinas listarDisciplinas)
        {
            this.listarDisciplinas = listarDisciplinas 
                ?? throw new ArgumentNullException(nameof(listarDisciplinas));
        }

        /// <summary>
        /// Lista as disciplinas vinculadas a uma turma.
        /// </summary>
        /// <param name="idTurma"></param>
        /// <returns>Retorna uma lista de disciplinas.</returns>
        [HttpGet("{id}/Disciplinas")]
        [ProducesResponseType(typeof(IEnumerable<ListarDiciplinasSaida>), 200 )]
        public async Task<IActionResult> ListarDisciplinasAsync([FromRoute(Name = "id")] int idTurma)
        {
            return Ok(await listarDisciplinas.ListarDisciplinasAsync(idTurma));
        }
    }
}