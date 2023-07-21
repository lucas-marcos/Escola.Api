using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Framework;
using Escola.Api.Models;
using Escola.Api.Services.Interfaces;

namespace Escola.Api.Services;

public class AlunoServices : IAlunoServices
{
    private readonly IAlunoRepository _alunoRepository;

    public AlunoServices(IAlunoRepository alunoRepository)
    {
        _alunoRepository = alunoRepository;
    }

    public Aluno AdicionarAluno(Aluno aluno)
    {
        _alunoRepository.Adicionar(aluno);
        _alunoRepository.Salvar();

        return aluno;
    }

    public Aluno EditarAluno(Aluno alunoParaEditar)
    {
        var alunoCadastrado = _alunoRepository.BuscarPorId(alunoParaEditar.Id) ?? throw new PontoIdException("Aluno não encontrado");
        
        alunoCadastrado.Atualizar(alunoParaEditar);
        
        _alunoRepository.Atualizar(alunoCadastrado);
        _alunoRepository.Salvar();
        
        return alunoCadastrado;
    }

    public void DeletarAluno(int alunoId)
    {
        var aluno = _alunoRepository.BuscarPorId(alunoId) ?? throw new PontoIdException("Aluno não encontrado");
        
        _alunoRepository.Remover(alunoId);
        _alunoRepository.Salvar();
    }
    
    public List<Aluno> BuscarTodosAlunos() => _alunoRepository.BuscarTodosComIncludes().ToList();
}