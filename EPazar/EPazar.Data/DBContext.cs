using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EPazar.Entity.Entity;
using EPazar.Entity.XMLEntity;
using EPazar.Entity.View;

namespace EPazar.Data
{
    public class EFContext : DbContext
    {
        public static IConfiguration Configuration { get; }

        #region Constructor

        public EFContext()
        {
            if (!Database.CanConnect()) Database.EnsureCreatedAsync();
        }

        #endregion Constructor

        #region OnConfiguring

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json")
                 .Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("TTLOtomasyonDbConnection"));
            }
        }

        #endregion OnConfiguring

        #region OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<OdemeDurum>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<AnaKategoriler>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<AnasayfaBanner>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<AnasayfaTopBanner>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<AnasayfaSagBanner>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<AnasayfaMiniBanner>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<KategoriListesiTopBanner>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<KategoriListesiBanner>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Kategoriler>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<AltKategoriler>().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<HipatuAnaKategoriEsitleme> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Urunler> ().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<UrunResimleri> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<UrunOzellikleri> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<OzellikRenkleri> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<OzellikTur> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<UrunKategorileri> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Kullanicilar> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Sepet> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Siparis> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<SiparisDetay> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<KullaniciAdresleri> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<SiparisKargoBilgisi> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<KargoFirmalari> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Favoriler> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Tedarikciler> ().HasQueryFilter(x=> !x.Deleted);
            modelBuilder.Entity<Admin> ().HasQueryFilter(x=> !x.Deleted);

            modelBuilder.Entity<ViewSepet> ().HasKey(x=> x.UrunId);
            modelBuilder.Entity<ViewSiparisDetay> ().HasNoKey();
            modelBuilder.Entity<ViewSiparisTedarikciToplam> ().HasNoKey();


            base.OnModelCreating(modelBuilder);
        }

        #endregion OnModelCreating

     
        public virtual DbSet<OdemeDurum> OdemeDurum { get; set; }
        public virtual DbSet<AnaKategoriler> AnaKategoriler { get; set; }
        public virtual DbSet<AnasayfaBanner> AnasayfaBanner { get; set; }
        public virtual DbSet<AnasayfaTopBanner> AnasayfaTopBanner { get; set; }
        public virtual DbSet<AnasayfaSagBanner> AnasayfaSagBanner { get; set; }
        public virtual DbSet<AnasayfaMiniBanner> AnasayfaMiniBanner { get; set; }
        public virtual DbSet<KategoriListesiTopBanner> KategoriListesiTopBanner { get; set; }
        public virtual DbSet<KategoriListesiBanner> KategoriListesiBanner { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<AltKategoriler> AltKategoriler { get; set; }
        public virtual DbSet<HipatuAnaKategoriEsitleme> HipatuAnaKategoriEsitleme { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<UrunResimleri> UrunResimleri { get; set; }
        public virtual DbSet<UrunOzellikleri> UrunOzellikleri { get; set; }
        public virtual DbSet<OzellikRenkleri> OzellikRenkleri { get; set; }
        public virtual DbSet<OzellikTur> OzellikTur { get; set; }
        public virtual DbSet<UrunKategorileri> UrunKategorileri { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<ViewUrunOzellikleriAciklamali> ViewUrunOzellikleriAciklamali { get; set; }
        public virtual DbSet<Sepet> Sepet { get; set; }
        public virtual DbSet<ViewSepet> ViewSepet { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetay { get; set; }
        public virtual DbSet<KullaniciAdresleri> KullaniciAdresleri { get; set; }
        public virtual DbSet<ViewSiparisDetay> ViewSiparisDetay { get; set; }
        public virtual DbSet<SiparisKargoBilgisi> SiparisKargoBilgisi { get; set; }
        public virtual DbSet<ViewSiparisTedarikciToplam> ViewSiparisTedarikciToplam { get; set; }
        public virtual DbSet<KargoFirmalari> KargoFirmalari { get; set; }
        public virtual DbSet<Favoriler> Favoriler { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
    }
}