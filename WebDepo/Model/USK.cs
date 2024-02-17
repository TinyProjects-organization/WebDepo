using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLUsk")]
    public class USK
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long EtiketId { get; set; }

        [Required]
        public Int16 UretimDepo { get; set; }

        [Required]
        [MaxLength(15)]
        public string BelgeSeri { get; set; }

        [Required]
        [MaxLength(15)]
        public string IsEmriNo { get; set; }

        [Required]
        public long IsEmriId { get; set; }

        [Required]
        public bool SilindiMi { get; set; } = false;

        [Required]
        public bool NetsiseAtildiMi { get; set; } = false;

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
