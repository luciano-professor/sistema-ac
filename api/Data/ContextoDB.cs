using Microsoft.EntityFrameworkCore;
using WebAcc.Models;

namespace WebAcc.Data;

public class ContextoDB : DbContext
{
    public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
    {

    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Perfil> Perfis { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<UsuarioCurso> UsuariosCurso { get; set; }
    public DbSet<Versao> Versoes { get; set; }
    public DbSet<Regra> Regras { get; set; }
    public DbSet<Submissao> Submissoes { get; set; }
}
