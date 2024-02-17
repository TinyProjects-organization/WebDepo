using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLUretimTalep")]
    public class UretimTalep
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long UretimMasId { get; set; }

        [Required]
        [MaxLength(50)]
        public string StokKodu { get; set; }

        [Required]
        [Column(TypeName = "double(30, 8)")]
        public double Miktar { get; set; }

        [Required]
        [MaxLength(50)]
        public string SeriNo { get; set; }

        [Required]
        public bool OnayDurumu { get; set; } = false;

        [Required]
        public bool SilindiMi { get; set; } = false;

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
