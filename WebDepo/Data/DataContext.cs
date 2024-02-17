global using Microsoft.EntityFrameworkCore;
using WebDepo.Model;

namespace WebDepo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;DataBase=WMS;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Etiket> BarkodS { get; set; }
        public DbSet<DepoTransferMas> DepoTransferMasS { get; set; }
        public DbSet<DepoTransferTalep> DepoTransferTalepS { get; set; }
        public DbSet<DepoTransferTra> DepoTransferTraS { get; set; }
        public DbSet<EIrsaliyeDepoTanimi> EIrsaliyeDepoTanimisS { get; set; }
        public DbSet<EtiketGecmisiMas> EtiketGecmisiMasS { get; set; }
        public DbSet<EtiketGecmisiTra> EtiketGecmisiTraS { get; set; }
        public DbSet<IrsaliyeSiparisEsleme> IrsaliyeSiparisEslemeS { get; set; }
        public DbSet<KullaniciSirketEsleme> KullaniciSirketEslemeS { get; set; }
        public DbSet<MalKabulMas> MalKabulS { get; set; }
        public DbSet<OnayliDatDepoTanimlama> OnayliDatDepoTanimlamaS { get; set; }
        public DbSet<Raf> RafS { get; set; }
        public DbSet<Recete> ReceteS { get; set; }
        public DbSet<SevkMas> SevkMasS { get; set; }
        public DbSet<SevkTalep> SevkTalepS { get; set; }
        public DbSet<SevkTra> SevkTraS { get; set; }
        public DbSet<Sirketler> SirketlerS { get; set; }
        public DbSet<Terminal> TerminalS { get; set; }
        public DbSet<TerminalUser> TerminalUserS { get; set; }
        public DbSet<UretimMas> UretimMasS { get; set; }
        public DbSet<UretimTalep> UretimTalepS { get; set; }
        public DbSet<UretimTra> UretimTraS { get; set; }
        public DbSet<User> UserS { get; set; }
        public DbSet<USK> USKS { get; set; }
        public DbSet<UskTuketim> UskTuketimS { get; set; }

    }
}
