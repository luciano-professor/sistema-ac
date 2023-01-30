using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAcc.Models;

public class Curso
{
    [Required]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(40)")]
    public string Nome { get; set; }

    //Propriedades de Navegação:

    public List<UsuarioCurso> UsuarioCursos { get; set; }
    public List<Versao> Versoes { get; set; }
}
