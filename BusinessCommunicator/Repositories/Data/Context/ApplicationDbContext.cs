using BusinessCommunicator.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessCommunicator.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        // definiowanie dbsetów (tworzenie bazy danych)
        public DbSet<Message> Message { get; set; }
        public DbSet<User> User { get; set; }

        //metoda do migracji pochodzi z klasy DbContext
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}