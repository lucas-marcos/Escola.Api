using Microsoft.EntityFrameworkCore;

namespace Escola.Api.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Models.Escola> Escolas { get; private set; }
    public DbSet<Models.Aluno> Alunos { get; private set; }
    public DbSet<Models.Turma> Turmas { get; private set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        foreach (var property in builder.Model.GetEntityTypes()
                     .SelectMany(t => t.GetProperties())
                     .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18, 6)");
        }
        
        builder.Entity<Models.Escola>()
            .HasMany(p => p.Turmas)
            .WithOne(f => f.Escola)
            .HasForeignKey(f => f.EscolaId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}