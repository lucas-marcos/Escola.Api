using Escola.Api.Data;

namespace Escola.Api.Models;

public class Turma : Entity
{
    public string Nome { get; private set; }
    public int Numero { get; private set; }
    public string Descricao { get; private set; }

    public int EscolaId { get; set; }
    public Escola Escola { get; set; }
    public List<Aluno> Alunos { get; private set; }

    public Turma()
    {
        
    }
    
    public void Atualizar(Turma turma)
    {
        SetNome(turma.Nome);
        SetNumero(turma.Numero);
        SetDescricao(turma.Descricao);
        SetEscolaId(turma.EscolaId);
    }
    
    //criar setters
    public void SetNome(string nome) => Nome = nome;
    
    public void SetNumero(int numero) => Numero = numero;
    public void SetDescricao(string descricao) => Descricao = descricao;
    public void SetEscolaId(int escolaId) => EscolaId = escolaId;
    
    
}