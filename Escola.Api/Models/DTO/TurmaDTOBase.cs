using System.ComponentModel.DataAnnotations;

namespace Escola.Api.Models.DTO;

public class TurmaDTOBase
{
    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Nome não pode ter mais de 100 caracteres.")]
    public string Nome { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "O campo Numero deve ser um valor positivo maior que zero.")]
    public int Numero { get; set; }

    [StringLength(500, ErrorMessage = "O campo Descrição não pode ter mais de 500 caracteres.")]
    public string Descricao { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Deve informar uma escola válida.")]
    public int EscolaId { get; set; }
}
