using Escola.Api.Data;

namespace Escola.Api.Models;

public class Escola : Entity
{
    public string Nome { get; private set; }
    public string Endereco { get; private set; }
    public string Telefone { get; private set; }
    public string Email { get; private set; }
    public string Cnpj { get; private set; }
    
    public List<Turma> Turmas { get; private set; } = new List<Turma>();
    
    public Escola()
    {                                                                                
        
    }

    public void Atualizar(Escola escola)
    {
        SetNome(escola.Nome);
        SetEndereco(escola.Endereco);
        SetTelefone(escola.Telefone);
        SetEmail(escola.Email);
        SetCnpj(escola.Cnpj);
    }
    
    public void SetNome(string nome) => Nome = nome;
    public void SetEndereco(string endereco) => Endereco = endereco;
    public void SetTelefone(string telefone) => Telefone = telefone;
    public void SetEmail(string email) => Email = email;
    public void SetCnpj(string cnpj) => Cnpj = cnpj;
}