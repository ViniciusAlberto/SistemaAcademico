using Application.UseCase.Disciplina.ListarDisciplina;
using AutoMapper;
using Domain.Models.Disciplina;

namespace Presentation
{
    public class PresentationProfile: Profile
    {
        public PresentationProfile()
        {
            CreateMap<IDisciplina, ListarDiciplinasSaida>();
        }
    }
}
