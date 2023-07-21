using AutoMapper;
using Escola.Api.Models.DTO;
using Escola.Api.Models.TO;

namespace Escola.Api.Models.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<EscolaParaCadastrarDTO, Escola>();
        CreateMap<EscolaParaEditarDTO, Escola>();
        CreateMap<Escola, EscolaTO>();

        CreateMap<TurmaParaCadastrarDTO, Turma>();
        CreateMap<Turma, TurmaTO>();
    }
}