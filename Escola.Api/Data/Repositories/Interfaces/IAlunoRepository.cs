using Escola.Api.Models;

namespace Escola.Api.Data.Repositories.Interfaces;

public interface IAlunoRepository : IRepository<Aluno>
{
    IQueryable<Aluno> BuscarTodosComIncludes();
}