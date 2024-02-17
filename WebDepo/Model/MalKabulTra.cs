using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLMalKabulMas")]
    public class MalKabulTra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Etiket { get; set; }

        public DateTime? Skt { get; set; }

        public string PartiNo { get; set; } // Nullable string

        [Required]
        public int DepoKodu { get; set; }

        [Required]
        public double Miktar { get; set; }

        [Required]
        public bool SilindiMi { get; set; } = false; // Corrected capitalization

        public long OlusturanKullaniciId { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public long? GuncelleyenKullaniciId { get; set; } // Nullable long

        public DateTime? GuncellenmeTarihi { get; set; } // Nullable DateTime

        public long? SilenKullaniciId { get; set; } // Nullable long

        public DateTime? SilinmeTarihi { get; set; } // Nullable DateTime

    }
}
