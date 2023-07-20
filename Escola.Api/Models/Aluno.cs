using Escola.Api.Data;

namespace Escola.Api.Models;

public class Aluno : Entity
{
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public string Endereco { get; private set; }
    public int Idade { get; private set; }
    
    public Turma Turma { get; private set; }
    public int TurmaId { get; private set; }

    public Aluno()
    {
        
    }
}