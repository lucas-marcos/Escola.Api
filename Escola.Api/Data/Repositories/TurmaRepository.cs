using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Api.Data.Repositories;

public class TurmaRepository : Repository<Turma>, ITurmaRepository
{
    public TurmaRepository(ApplicationDbContext context) : base(context)
    {
    }

    public IQueryable<Turma> BuscarTodosComIncludes()
    {
        return BuscarTodos()
            .Include(a => a.Escola);
    }
}