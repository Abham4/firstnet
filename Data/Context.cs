using firstnet.Model;
using Microsoft.EntityFrameworkCore;

namespace firstnet.Data;

public class Context:DbContext {

public Context(DbContextOptions<Context> options):base(options) {
        
}
public DbSet<Member>Members { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}