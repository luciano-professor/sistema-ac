using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAcc.Models;

public class Perfil
{
    [Required]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(60)")]
    public string Nome { get; set; }

    //Propriedade de Navegação:

    public List<Usuario> Usuarios { get; set; }
}
