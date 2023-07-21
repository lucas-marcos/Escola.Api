using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Models;
using Escola.Api.Services.Interfaces;

namespace Escola.Api.Services;

public class TurmaServices : ITurmaServices
{
    private readonly ITurmaRepository _turmaRepository;

    public TurmaServices(ITurmaRepository turmaRepository)
    {
        _turmaRepository = turmaRepository;
    }

    public Turma CadastraTurma(Turma turmaParaCadastrar)
    {
        _turmaRepository.Adicionar(turmaParaCadastrar);
        _turmaRepository.Salvar();

        return turmaParaCadastrar;
    }
}