using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAcc.Models;

public class Regra
{
    [Required]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Nome { get; set; }

    [Required]
    public int HorasPorCertificado { get; set; }

    [Required]
    public int MaximoDeHoras { get; set; }

    [Required]
    public int VersaoId { get; set; }

    //Propriedades de Navegação:

    public Versao Versao { get; set; }
    public List<Submissao> Submissoes { get; set; }
}
