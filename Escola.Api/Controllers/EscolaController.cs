using AutoMapper;
using Escola.Api.Models.DTO;
using Escola.Api.Models.TO;
using Escola.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController, Route("[controller]")]
public class EscolaController : ControllerBase
{
    private readonly IEscolaServices _escolaServices;
    private readonly IMapper _mapper;

    public EscolaController(IEscolaServices escolaServices, IMapper mapper)
    {
        _escolaServices = escolaServices;
        _mapper = mapper;
    }
          
    [HttpPost]
    public ActionResult<EscolaTO> CadastrarEscola(EscolaParaCadastrarDTO escolaParaCadastrar)
    {
        var escola = _escolaServices.CadastrarEscola(_mapper.Map<Models.Escola>(escolaParaCadastrar));
        
        return Ok(_mapper.Map<EscolaTO>(escola));
    }
    
    [HttpGet]
    public ActionResult<List<EscolaTO>> RetornarTodasEscolas()
    {
        var escolas = _escolaServices.RetornarTodasEscolas();
        
        return Ok(_mapper.Map<List<EscolaTO>>(escolas));
    }
    
}