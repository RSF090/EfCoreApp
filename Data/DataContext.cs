using Microsoft.EntityFrameworkCore;

namespace EfCoreApp.Data
{
    public class DataContext : DbContext
    {
        // ──────────── 1) PARAMETRELİ KURUCU ────────────
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // ──────────── 2) DbSet’ler ────────────
        public DbSet<Kurs> Kurslar           { get; set; } = null!;
        public DbSet<Ogrenci> Ogrenciler     { get; set; } = null!;
        public DbSet<KursKayit> KursKayitlar { get; set; } = null!;

    }
}
