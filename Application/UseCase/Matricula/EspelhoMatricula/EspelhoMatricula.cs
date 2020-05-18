using AutoMapper;
using Domain.Models.Matricula;
using Domain.Service.Matricula;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCase.Matricula.EspelhoMatricula
{
    public class EspelhoMatricula : IEspelhoMatricula
    {
        private readonly IMatriculaService matriculaService;
        private readonly IMapper mapper;
        public EspelhoMatricula(IMatriculaService matriculaService, IMapper mapper)
        {
            this.matriculaService = matriculaService 
                ?? throw new ArgumentNullException(nameof(matriculaService));

            this.mapper = mapper
               ?? throw new ArgumentNullException(nameof(mapper));
        }
       
        public async Task<EspelhoMatriculaSaida> EspelhoMatriculaAsync(int IdAluno)
        {
            var matricula = await matriculaService.EspelhoMatriculaAsync(IdAluno);

            return mapper.Map<EspelhoMatriculaSaida>(matricula);
        }
    }
}
