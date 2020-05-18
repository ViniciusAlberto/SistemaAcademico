using Application.UseCase.Disciplina.ListarDisciplina;
using AutoMapper;
using Domain.Service.Disciplina;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.UseCase.Disciplina
{
    public class ListarDisciplinas : IListarDisciplinas
    {
        private readonly IDisciplinaService disciplinaService;
        private readonly IMapper mapper;

        public ListarDisciplinas(IDisciplinaService disciplinaService, IMapper mapper)
        {
            this.disciplinaService = disciplinaService 
                ?? throw new ArgumentNullException(nameof(disciplinaService));

            this.mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<ListarDiciplinasSaida>> ListarDisciplinasAsync(int IdTurma)
        {
            var disciplinas = await disciplinaService.ListarDisciplinasAsync(IdTurma);

            return mapper.Map<IEnumerable<ListarDiciplinasSaida>>(disciplinas);
        }
    }
}