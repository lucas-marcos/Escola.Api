using Escola.Api.Models;

namespace Escola.Api.Services.Interfaces;

public interface ITurmaServices
{
    Turma CadastraTurma(Turma turmaParaCadastrar);
    List<Turma> BuscarTodasTurmas();
    Turma EditarTurma(Turma turmaParaEditar);
}