using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAcc.Models;

public class Submissao
{
    [Required]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "Decimal(4,1)")]

    public decimal Horas { get; set; }

    [Required]
    [Column(TypeName = "varchar(100)")]

    public string Caminho { get; set; }

    [Required]
    public int UsuarioCursoId { get; set; }

    [Required]
    public int RegraId { get; set; }

    //Propriedades de Navegação:

    public UsuarioCurso UsuarioCurso { get; set; }
    public Regra Regra { get; set; }
}
