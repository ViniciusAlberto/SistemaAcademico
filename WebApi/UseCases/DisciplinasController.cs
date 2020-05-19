using Application.UseCase.DisciplinaMatricula.CancelamentoMatricula;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebApi.UseCases
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinasController : ControllerBase
    {
        private readonly ICancelamentoMatricula cancelamentoMatricula;

        public DisciplinasController(ICancelamentoMatricula cancelamentoMatricula)
        {

            this.cancelamentoMatricula = cancelamentoMatricula
                ?? throw new ArgumentNullException(nameof(cancelamentoMatricula));
        }
        /// <summary>
        /// Realiza o cancelamento de uma matrícula em um disciplina
        /// </summary>
        /// <param name="cancelamentoMatriculaEntrada"></param>
        /// <returns>Retorna se a matricula foi cancelada ou não.</returns>
        [HttpPost("CancelarMatricula")]
        [ProducesResponseType(typeof(CancelamentoMatriculaEntrada), 200)]
        public async Task<IActionResult> CancelarDisciplinaAsync(CancelamentoMatriculaEntrada cancelamentoMatriculaEntrada)
        {
            return Ok(await cancelamentoMatricula.CancelarDisciplinaAsync(cancelamentoMatriculaEntrada));
        }
    }
}