using Application.UseCase.Matricula;
using Application.UseCase.Matricula.EspelhoMatricula;
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
        private readonly IEspelhoMatricula espelhoMatricula;

        public MatriculasController(ICadastroMatricula cadastroMatricula, IEspelhoMatricula espelhoMatricula)
        {
            this.cadastroMatricula = cadastroMatricula 
                ?? throw new ArgumentNullException(nameof(cadastroMatricula));

            this.espelhoMatricula = espelhoMatricula
                ?? throw new ArgumentNullException(nameof(espelhoMatricula));
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