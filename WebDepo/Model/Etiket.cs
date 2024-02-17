using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLEtiket")]
    public class Etiket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string EtiketNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string StokKodu { get; set; }

        [Required]
        [Column(TypeName = "double(30, 8)")]
        public double Miktar { get; set; }

        [Required]
        [MaxLength(50)]
        public string KoliEtiketi { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaletEtiketi { get; set; }

        public DateTime? Skt { get; set; }

        public Int16 Gkk { get; set; }

        [Required]
        [MaxLength(50)]
        public string AnaEtiket { get; set; }

        [Required]
        [MaxLength(50)]
        public string MalKabulEtiketi { get; set; }

        [Required]
        [MaxLength(50)]
        public string PartiNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string RafEtiketi { get; set; }

        [Required]
        public bool DepodaMi { get; set; } = true;

        [Required]
        public Int16 DepoKodu { get; set; }

        [Required]
        public bool silindiMi { get; set; } = false;

        public long OlusturanKullaniciId { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public long? GuncelleyenKullaniciId { get; set; }

        public DateTime? GuncellenmeTarihi { get; set; }

        public long? SilenKullaniciId { get; set; }

        public DateTime? SilinmeTarihi { get; set; }

        [Required]
        [MaxLength(50)]
        public string SirketKodu { get; set; }
    }
}
