﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLMalKabulMas")]
    public class MalKabulMas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CariKodu { get; set; }

        [Required]
        [StringLength(50)]
        public string IrsaliyeNo { get; set; }

        [Required]
        public bool NetsiseAtildiMi { get; set; } = false;

        [Required]
        public bool SilindiMi { get; set; } = false; // Corrected capitalization

        public long OlusturanKullaniciId { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public long? GuncelleyenKullaniciId { get; set; } // Nullable long

        public DateTime? GuncellenmeTarihi { get; set; } // Nullable DateTime

        public long? SilenKullaniciId { get; set; } // Nullable long

        public DateTime? SilinmeTarihi { get; set; } // Nullable DateTime

        [Required]
        [MaxLength(10)]
        public string SirketKodu { get; set; }
    }
}
