namespace Escola.Api.Models.DTO;

using System.ComponentModel.DataAnnotations;

public class AlunoParaCadastrarDTO
{
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Nome não pode ter mais de 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo CPF é obrigatório.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo CPF deve conter exatamente 11 dígitos.")]
    public string Cpf { get; set; }

    [StringLength(200, ErrorMessage = "O campo Endereço não pode ter mais de 200 caracteres.")]
    public string Endereco { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "A idade deve estar ser maior que 1.")]
    public int Idade { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "O campo TurmaId deve ser um valor positivo maior que zero.")]
    public int TurmaId { get; set; }
}
