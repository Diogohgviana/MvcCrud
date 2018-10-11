using System.Data.Entity;

namespace MvcCrud.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Tarefas> usuario { get; set; }
    } 
}