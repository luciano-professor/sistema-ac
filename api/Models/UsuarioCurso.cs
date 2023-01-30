using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAcc.Models;

public class UsuarioCurso
{
    [Required]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "Decimal(4,1)")]
    public decimal TotalDeHoras { get; set; }

    [Required]
    public int UsuarioId { get; set; }

    [Required]
    public int CursoId { get; set; }

    [Required]
    public int VersaoId { get; set; }

    //Propriedades de Navegação:

    public Usuario Usuario { get; set; }
    public Curso Curso { get; set; }
    public Versao Versao { get; set; }
}
