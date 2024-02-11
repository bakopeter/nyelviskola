using Microsoft.EntityFrameworkCore;

namespace NyelviskolaCL.Models
{
    public class NyelviskolaContext : DbContext
    {
        public DbSet<Tanitvany> Tanitvanyok { get; set; }
        public DbSet<Tanar> Tanarok { get; set; }
        public DbSet<Nyelv> Nyelvek { get; set; }
        public DbSet<TanitasiAlkalom> TanitasiAlkalmak { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;database=nyelviskola");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tanitvany>(entity =>
            {
                entity.HasKey(e => e.TanitvanyId);
                entity.Property(e => e.Nev).IsRequired();
                entity.Property(e => e.Telefon).IsRequired();
                entity.Property(e => e.Email).IsRequired();
            });

            modelBuilder.Entity<Tanar>(entity =>
            {
                entity.HasKey(e => e.TanarId);
                entity.Property(e =>e.Nev).IsRequired();
                entity.Property(e => e.Oradij).IsRequired();
                entity.Property(e => e.Telefon).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Net).IsRequired();
                entity.HasOne(d => d.Nyelv).WithMany(p => p.Tanarok);
            });

            modelBuilder.Entity<Nyelv>(entity =>
            {
                entity.HasKey(e => e.NyelvId);
                entity.Property(e => e.Nyelvnev).IsRequired();
            });

            modelBuilder.Entity<TanitasiAlkalom>(entity =>
            {
                entity.HasKey(e => e.AlkalomId);
                entity.Property(e => e.Datum);
                entity.Property(e => e.Kezdesido);
                entity.Property(e => e.OrakSzama);
                entity.HasOne(d => d.Tanar).WithMany(p => p.TanitasiAlkalmak);
                entity.HasOne(d => d.Tanitvany).WithMany(p => p.TanitasiAlkalmak);
            });
        }
    }
}
