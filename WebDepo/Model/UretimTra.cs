using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLUretimTra")]
    public class UretimTra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long UretimMasId { get; set; }

        [Required]
        public long EtiketId { get; set; }
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
