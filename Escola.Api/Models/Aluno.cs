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

    public void Atualizar(Aluno aluno)
    {
        SetNome(aluno.Nome);
        SetCpf(aluno.Cpf);
        SetEndereco(aluno.Endereco);
        SetIdade(aluno.Idade);
        SetTurma(aluno.Turma);
        SetTurmaId(aluno.TurmaId);
    }

    public void SetNome(string nome) => Nome = nome;
    public void SetCpf(string cpf) => Cpf = cpf;
    public void SetEndereco(string endereco) => Endereco = endereco;
    public void SetIdade(int idade) => Idade = idade;
    public void SetTurma(Turma turma) => Turma = turma;
    public void SetTurmaId(int turmaId) => TurmaId = turmaId;
}