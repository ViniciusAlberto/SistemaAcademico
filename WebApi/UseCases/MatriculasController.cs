using Application.UseCase.Matricula;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculasController : ControllerBase
    {
        private readonly ICadastroMatricula cadastroMatricula;

        public MatriculasController(ICadastroMatricula cadastroMatricula)
        {
            this.cadastroMatricula = cadastroMatricula 
                ?? throw new ArgumentNullException(nameof(cadastroMatricula));
        }

        /// <summary>
        /// Realiza a matrícula de um aluno em uma ou mais disciplinas.
        /// </summary>
        /// <param name="matriculaEntrada"></param>
        /// <returns>Retorna a matrícula gerada para o aluno.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(MatriculaEntrada), 200)]
        public async Task<IActionResult> RegistraMatriculaAsync(MatriculaEntrada matriculaEntrada)
        {
            return Ok(await cadastroMatricula.RealizaMatriculaAsync(matriculaEntrada));
        }
    }
}