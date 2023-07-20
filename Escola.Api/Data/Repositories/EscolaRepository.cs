using Escola.Api.Data.Repositories.Interfaces;

namespace Escola.Api.Data.Repositories;

public class EscolaRepository : Repository<Models.Escola>, IEscolaRepository
{
    public EscolaRepository(ApplicationDbContext context) : base(context)
    {
    }
}