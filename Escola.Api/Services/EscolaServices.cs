using Escola.Api.Data.Repositories.Interfaces;
using Escola.Api.Services.Interfaces;

namespace Escola.Api.Services;

public class EscolaServices : IEscolaServices
{
    private readonly IEscolaRepository _escolaRepository;

    public EscolaServices(IEscolaRepository escolaRepository)
    {
        _escolaRepository = escolaRepository;
    }
    
    public Models.Escola CadastrarEscola(Models.Escola escolaModel)
    {
        _escolaRepository.Adicionar(escolaModel);
        _escolaRepository.Salvar();

        return escolaModel;
    }
}