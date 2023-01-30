using System.ComponentModel.DataAnnotations;

namespace WebAcc.Models;

public class Versao
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int NumeroVersao { get; set; }

    [Required]
    public int CursoId { get; set; }

    //Propriedades de Navegação:

    public Curso Curso { get; set; }
    public List<UsuarioCurso> UsuarioCursos { get; set; }
    public List<Regra> Regras { get; set; }
}
