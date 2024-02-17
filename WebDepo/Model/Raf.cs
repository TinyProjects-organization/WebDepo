using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLRaf")]
    public class Raf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public Int16 DepoKodu { get; set; }

        [Required]
        [MaxLength(100)]
        public string RafEtiket { get; set; }

        [Required]
        [MaxLength(100)]
        public string RafKodu { get; set; }

        [Required]
        [MaxLength(100)]
        public string Alt { get; set; }

        [Required]
        [MaxLength(100)]
        public string Ust { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sag { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sol { get; set; }

        [Required]
        public double MaxRafAgirligi { get; set; }

        [Required]
        [MaxLength(100)]
        public string RafHacmi {  get; set; }

        public long OlusturanKullaniciId { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public long? GuncelleyenKullaniciId { get; set; }

        public DateTime? GuncellenmeTarihi { get; set; }

        public long? SilenKullaniciId { get; set; }

        public DateTime? SilinmeTarihi { get; set; }


        public bool SilindiMi { get; set; } = false;

        [Required]
        [MaxLength(50)]
        public string SirketKodu { get; set; }
    }
}
