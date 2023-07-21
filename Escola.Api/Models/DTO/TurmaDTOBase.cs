namespace Escola.Api.Models.DTO;

public class TurmaDTOBase
{
    public string Nome { get; set; }
    public int Numero { get; set; }
    public string Descricao { get; set; }
    public int EscolaId { get; set; }
}