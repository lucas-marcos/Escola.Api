using AutoMapper;
using Escola.Api.Models;
using Escola.Api.Models.DTO;
using Escola.Api.Models.TO;
using Escola.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController, Route("[controller]")]
public class TurmaController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ITurmaServices _turmaServices;

    public TurmaController(IMapper mapper, ITurmaServices turmaServices)
    {
        _mapper = mapper;
        _turmaServices = turmaServices;
    }

    [HttpPost]
    public ActionResult<TurmaTO> CadastrarTurma(TurmaParaCadastrarDTO turmaParaCadastrar)
    {
        var turma = _turmaServices.CadastraTurma(_mapper.Map<Turma>(turmaParaCadastrar));

        return Ok(_mapper.Map<TurmaTO>(turma));
    }
    
}