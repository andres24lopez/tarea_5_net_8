using Microsoft.EntityFrameworkCore;
namespace apiempresa.models;

public class Conexiones : DbContext{

        public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }
     public DbSet<Proveedores> Proveedores { get; set; } = null!;
    public DbSet<clientes> clientes { get; set; } = null!;

}