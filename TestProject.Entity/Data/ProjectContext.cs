namespace TestProject.Entity.Data;
using Microsoft.EntityFrameworkCore;
using TestProject.Entity.Models;

public class ProjectContext : DbContext
{
    public ProjectContext()
    {

    }
    public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
    {

    }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DbInitializer(modelBuilder).Seed();
    }

}
