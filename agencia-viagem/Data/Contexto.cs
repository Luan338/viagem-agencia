using agencia_viagem.Models;
using Microsoft.EntityFrameworkCore;

namespace agencia_viagem.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=root; Initial  Catalog=agencia-viagem; Integrated Security=True");
        }

        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destino>(table =>
            {
                table.ToTable("Destinos");
                table.HasKey(prop => prop.Cod);
                table.Property(prop => prop.Destinos).HasMaxLength(20).IsRequired();
                table.Property(prop => prop.Embarque).IsRequired();
                table.Property(prop => prop.Data).HasColumnType("char(10)");
                table.Property(prop => prop.Hora).HasColumnType("char(10)");
            });

            modelBuilder.Entity<Contato>(table =>
            {
                table.ToTable("Contatos");
                table.HasKey(prop => prop.IdContato);
                table.Property(prop => prop.Nome).HasMaxLength(20).IsRequired();
                table.Property(prop => prop.Email).IsRequired();
                table.Property(prop => prop.Mensagem).HasColumnType("char(10)");
            });
        }

    }
}
