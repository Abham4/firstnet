using firstnet.Model;
using Microsoft.EntityFrameworkCore;

namespace firstnet.Data;

public class Context:DbContext {

    public Context(DbContextOptions<Context> options):base(options) {

    }

    public DbSet<Member>Members { get; set; }

    public DbSet<Stud>Studs { get; set; }

    public DbSet<Staff>Staffs { get; set; }
    public DbSet<User>Users { get; set;}
     public DbSet<Check>Checks { get; set; }
    public DbSet<Organization>Organizations { get; set;}
    public DbSet<CheckOrganizaion>CheckOrganizaions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>(user => {
            user.HasOne(u => u.Stud).WithOne(p => p.User).HasForeignKey<User>(f => f.Id).IsRequired();
        });
        modelBuilder.Entity<Member>(mem => {
            mem.HasMany(m => m.Staff).WithOne(p => p.Member).HasForeignKey(f => f.MemberId).IsRequired();
        });
    }
}
