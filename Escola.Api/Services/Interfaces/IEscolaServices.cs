namespace Escola.Api.Services.Interfaces;

public interface IEscolaServices
{
    Models.Escola CadastrarEscola(Models.Escola escolaModel);
    List<Models.Escola> RetornarTodasEscolas();
    void RemoverEscola(int escolaId);
    Models.Escola EditarEscola(Models.Escola escolaModel);
}