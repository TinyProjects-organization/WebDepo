using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLIrsaliyeSiparisEsleme")]
    public class IrsaliyeSiparisEsleme
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string IrsaliyeNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string SiparisNo { get; set; }

        [Required]
        [MaxLength(50)]
        public string IrsaliyeTipi { get; set; }

        [Required]
        [MaxLength(50)]
        public string CariKodu { get; set; }

        [Required]
        public bool silindiMi { get; set; } = false;

        public long OlusturanKullaniciId { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public long? GuncelleyenKullaniciId { get; set; }

        public DateTime? GuncellenmeTarihi { get; set; }

        public long? SilenKullaniciId { get; set; }

        public DateTime? SilinmeTarihi { get; set; }
    }
}