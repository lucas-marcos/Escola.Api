using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Models;

namespace Escola.Api.Data.Repositories;

public class TurmaRepository : Repository<Turma>, ITurmaRepository
{
    public TurmaRepository(ApplicationDbContext context) : base(context)
    {
    }
}