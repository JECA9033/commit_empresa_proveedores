using Microsoft.EntityFrameworkCore;
namespace ApiEmpresa.Models;

public class Conexiones : DbContext {
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){}

    public DbSet<Proveedores> Proveedores { get; set; } = null!;
}