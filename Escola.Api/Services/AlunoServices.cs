using Escola.Api.Data.Repositories.Interfaces;
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

    public List<Aluno> BuscarTodosAlunos() => _alunoRepository.BuscarTodosComIncludes().ToList();
}