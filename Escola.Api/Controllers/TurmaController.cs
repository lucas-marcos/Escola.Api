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
    
    [HttpGet]
    public ActionResult<TurmaTO> RetornarTodasTurmas()
    {
        var turmas =  _turmaServices.BuscarTodasTurmas();
        
        return Ok(_mapper.Map<List<TurmaTO>>(turmas));
    }

    [HttpPut]
    public ActionResult<TurmaTO> EditarTurma(TurmaParaEditarDTO turmaParaEditar)
    {
        var turma = _turmaServices.EditarTurma(_mapper.Map<Turma>(turmaParaEditar));
        
        return Ok(_mapper.Map<TurmaTO>(turma));
    }

    [HttpDelete, Route("{id}")]
    public ActionResult DeletarTurma(int id)
    {
        _turmaServices.DeletarTurma(id);
        
        return Ok();
    }
}