using Application.UseCase.Disciplina.ListarDisciplina;
using Application.UseCase.Matricula.EspelhoMatricula;
using AutoMapper;
using Domain.Models.Disciplina;
using Domain.Models.Matricula;

namespace Presentation
{
    public class PresentationProfile: Profile
    {
        public PresentationProfile()
        {
            CreateMap<IDisciplina, ListarDiciplinasSaida>();
            CreateMap<IMatricula, EspelhoMatriculaSaida>();
        
        }
    }
}
