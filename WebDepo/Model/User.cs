using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLUser")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Eposta { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sifre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Rol { get; set; }

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
