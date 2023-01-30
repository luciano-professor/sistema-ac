using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAcc.Models;

[Index(nameof(Email), IsUnique = true)]
public class Usuario
{
    [Required]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; }

    [Required]
    [Column(TypeName = "varchar(60)")]
    public string Senha { get; set; }

    [Required]
    public int PerfilId { get; set; }

    //Propriedades de Navegação:
    public Perfil Perfil { get; set; }
    public List<UsuarioCurso> UsuarioCurso { get; set; }
}
