using AutoMapper;
using Escola.Api.Models;
using Escola.Api.Models.DTO;
using Escola.Api.Models.TO;
using Escola.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Api.Controllers;

[ApiController, Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IAlunoServices _alunoServices;

    public AlunoController(IMapper mapper, IAlunoServices alunoServices)
    {
        _mapper = mapper;
        _alunoServices = alunoServices;
    }

    [HttpPost]
    public ActionResult<AlunoTO> AdicionarAluno(AlunoParaCadastrarDTO alunoParaCadastrar)
    {
        var aluno = _alunoServices.AdicionarAluno(_mapper.Map<Aluno>(alunoParaCadastrar));
        
        return Ok(_mapper.Map<AlunoTO>(aluno));
    }

    [HttpGet]
    public ActionResult<List<AlunoTO>> ListarAlunos()
    {
        var alunos = _alunoServices.BuscarTodosAlunos();
        
        return Ok(_mapper.Map<List<AlunoTO>>(alunos));
    }

    [HttpPut]
    public ActionResult<AlunoTO> EditarAluno(AlunoParaEditarDTO alunoParaEditar)
    {
        var aluno = _alunoServices.EditarAluno(_mapper.Map<Aluno>(alunoParaEditar));
        
        return Ok(_mapper.Map<AlunoTO>(aluno));
    }
    
    [HttpDelete("{id}")]
    public ActionResult DeletarAluno(int id)
    {
         _alunoServices.DeletarAluno(id);
        
        return Ok();
    }
}