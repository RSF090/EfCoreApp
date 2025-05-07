using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfCoreApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<Ogrenci> Öğrenciler { get; set; }
        public DbSet<KursKayit> KursKayitlar { get; set; }
    }
}