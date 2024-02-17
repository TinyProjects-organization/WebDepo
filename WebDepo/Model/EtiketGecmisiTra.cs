using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLEtiketGecmisiTra")]
    public class EtiketGecmisiTra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long EtiketGecmisiMasId { get; set; }
        
        [Required]
        public string AnaEtiket { get; set; }

        [Required]
        public string OlusanEtiket { get; set; }

        [Required]
        public double AnaEtiketMiktari { get; set; }

        public double OlusanEtiketMiktari { get; set; }

        [Required]
        public Int16 AnaDepoKodu { get; set; }

        [Required]
        public Int16 OlusanDepoKodu { get; set; }

        [Required]
        public IslemTipi IslemTipi { get; set; }

        [Required]
        public bool SilindiMi { get; set; } = false;

        public long OlusturanKullaniciId { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public long? GuncelleyenKullaniciId { get; set; }

        public DateTime? GuncellenmeTarihi { get; set; }

        public long? SilenKullaniciId { get; set; }

        public DateTime? SilinmeTarihi { get; set; }

    }
}
