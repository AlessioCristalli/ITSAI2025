using Microsoft.EntityFrameworkCore;
using WebChat.Dati.Strutture;
namespace WebChat.Dati
{
    public class BancaDati : DbContext
    {
        public DbSet<Gruppo> Gruppi { get; set; }
        public DbSet<Messaggio> Messaggi { get; set; }
        public DbSet<Utente> Utenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Messaggio>()
                .HasOne<Utente>(m => m.Mittente)
                .WithMany()
                .HasForeignKey("MittenteIDutente")
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Messaggio>()
                .HasOne<Utente>(m => m.Destinatario)
                .WithMany()
                .HasForeignKey("DestinatarioIDutente")
                .OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=WebChat.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
