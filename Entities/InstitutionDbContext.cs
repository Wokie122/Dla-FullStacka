using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Entities
{
    public class InstitutionDbContext : DbContext
    {
        private string _connectionString =
           "Server=(localdb)\\mssqllocaldb; Database= InstytucjeDb; Trusted_Connection=True;";
        public DbSet<Institution> Institution { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institution>()
                .Property(r => r.Name)
                .IsRequired();

            modelBuilder.Entity<Institution>()
                .Property(r => r.Voicodeship)
                .IsRequired();

            modelBuilder.Entity<Institution>()
                .Property(r => r.City)
                .IsRequired();

            modelBuilder.Entity<Institution>()
                .Property(r => r.PostalCode)
                .IsRequired();

            modelBuilder.Entity<Institution>()
                .Property(r => r.Street)
                .IsRequired();

            modelBuilder.Entity<Institution>()
                .Property(r => r.BuldingNumber)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.Voicodeship)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.City)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.Street)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.BuldingNumber)
                .IsRequired();

            modelBuilder.Entity<Customers>()
                .Property(r => r.Voicodeship)
                .IsRequired();

            modelBuilder.Entity<Customers>()
                .Property(r => r.City)
                .IsRequired();

            modelBuilder.Entity<Customers>()
                .Property(r => r.Street)
                .IsRequired();

            modelBuilder.Entity<Customers>()
                .Property(r => r.BuldingNumber)
                .IsRequired();

            modelBuilder.Entity<Customers>()
                .Property(r => r.Name)
                .IsRequired();

            modelBuilder.Entity<Customers>()
                .Property(r => r.LastName)
                .IsRequired();

            modelBuilder.Entity<Customers>()
                .Property(r => r.Age)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.Name)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.LastName)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.Age)
                .IsRequired();

            modelBuilder.Entity<Employees>()
                .Property(r => r.Postion)
                .IsRequired();

            modelBuilder.Entity<DocumentType>()
                .Property(r => r.Name)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
