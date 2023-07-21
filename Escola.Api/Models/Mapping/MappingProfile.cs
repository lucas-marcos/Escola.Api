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
        CreateMap<Turma, TurmaTO>()
            .ForMember(a => a.Descricao, b => b.MapFrom(c => c.Descricao))
            .ForMember(a => a.Escola, b => b.MapFrom(c => c.Escola.Nome))
            .ForMember(a => a.EscolaId, b => b.MapFrom(c => c.EscolaId))
            .ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
            .ForMember(a => a.Nome, b => b.MapFrom(c => c.Nome));
        CreateMap<TurmaParaEditarDTO, Turma>();
    }
}