﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.UseCase.Matricula.EspelhoMatricula;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.UseCases
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
      
        private readonly IEspelhoMatricula espelhoMatricula;

        public AlunosController( IEspelhoMatricula espelhoMatricula)
        {

            this.espelhoMatricula = espelhoMatricula
                ?? throw new ArgumentNullException(nameof(espelhoMatricula));
        }

        /// <summary>
        /// Mostar o espelho da Matricula do Aluno
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a matrícula do aluno.</returns>
        [HttpGet("{id}/Matriculas")]
        [ProducesResponseType(typeof(int), 200)]
        public async Task<IActionResult> EspelhoMatriculaAsync(int id)
        {
            return Ok(await espelhoMatricula.EspelhoMatriculaAsync(id));
        }
    }
}