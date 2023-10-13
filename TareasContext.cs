using Microsoft.EntityFrameworkCore;
using projectoef.Models;

namespace projectoef;

public class TareasContext : DbContext
{
  public DbSet<Categoria> categorias {get; set;}
  public DbSet<Tarea> tareas {get; set;}

  public TareasContext(DbContextOptions<TareasContext> options) : base(options)
  {
    
  }
}