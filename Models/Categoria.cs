namespace projectoef.Models;

public class Categoria
{
  public Guid categoriaId {get; set;}
  public string nombre {get; set;}
  public string descripcion {get; set;}
  public virtual ICollection<Tarea> tareas {get; set;}
}