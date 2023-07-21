using Escola.Api.Models;

namespace Escola.Api.Services.Interfaces;

public interface IAlunoServices
{
    Aluno AdicionarAluno(Aluno aluno);
    List<Aluno> BuscarTodosAlunos();
}