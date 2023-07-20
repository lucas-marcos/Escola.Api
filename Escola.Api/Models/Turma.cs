using Escola.Api.Data;

namespace Escola.Api.Models;

public class Turma : Entity
{
    public string Nome { get; private set; }
    public int Numero { get; private set; }
    public List<Aluno> Alunos { get; private set; }

    public Turma()
    {
        
    }
    
}