using System.ComponentModel.DataAnnotations;

namespace Escola.Api.Models.DTO;

public class EscolaParaCadastrarDTO
{
    [Required(ErrorMessage = "O nome da escola é obrigatório.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O endereço da escola é obrigatório.")]
    public string Endereco { get; set; }

    [Required(ErrorMessage = "O telefone da escola é obrigatório.")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O email da escola é obrigatório.")]
    [EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O CNPJ da escola é obrigatório.")]
    [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "Informe um CNPJ válido no formato xx.xxx.xxx/xxxx-xx.")]
    public string Cnpj { get; set; }  
}