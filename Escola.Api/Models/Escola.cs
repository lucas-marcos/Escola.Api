using Escola.Api.Data;

namespace Escola.Api.Models;

public class Escola : Entity
{
    public string Nome { get; private set; }
    public string Endereco { get; private set; }
    public string Telefone { get; private set; }
    public string Email { get; private set; }
    public string Cnpj { get; private set; }
    
    public List<Turma> Turmas { get; private set; }
    
    public Escola()
    {
        
    }
}