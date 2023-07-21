namespace Escola.Api.Models.TO;

public class AlunoTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
    public int Idade { get; set; }
    public string Turma { get; set; }
    public int TurmaId { get; set; }
}