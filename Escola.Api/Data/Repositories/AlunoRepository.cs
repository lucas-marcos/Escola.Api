using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Api.Data.Repositories;

public class AlunoRepository : Repository<Aluno>, IAlunoRepository
{
    public AlunoRepository(ApplicationDbContext context) : base(context)
    {
    }

    public IQueryable<Aluno> BuscarTodosComIncludes() =>
        BuscarTodos()
            .Include(a => a.Turma);
}