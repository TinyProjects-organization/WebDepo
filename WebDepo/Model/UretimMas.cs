using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLUretimMas")]
    public class UretimMas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public Int16 CikisDepo { get; set; }

        [Required]
        public Int16 VarisDepo { get; set; }

        [Required]
        [MaxLength(15)]
        public string BelgeSeri { get; set; }

        [Required]
        [MaxLength(50)]
        public string UretimIsEmriNo { get; set; }

        [Required]
        public bool IsEmriTamamlandiMi { get; set; } = false;

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
