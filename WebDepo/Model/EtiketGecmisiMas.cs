using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDepo.Model
{
    [Table("TBLEtiketGecmisiMas")]
    public class EtiketGecmisiMas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public long YapilanIsleminId { get; set; }

        [Required]
        public IslemTipi IslemTipi { get; set; }

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
    public enum IslemTipi
    {
        MalKabul = 0,
        PaletYap = 1,
        PaletBoz = 2,
        PaleteUrunEkle = 3,
        PalettenUrunCikar = 4,
        KoliYap = 5,
        KoliBoz = 6,
        KoliyeUrunEkle = 7,
        KolidenUrunCikar = 8,
        MiktarAl = 9,
        PaletlereAyir = 10,
        DAT = 11,
        DATOnay = 12,
        UretimeTransfer = 13,
        Uretim = 14,
        Sevkiyat = 15,
        SevkiyataTransfer = 16,
        Sayim = 17,
        LotBirlestir = 18
    }
}
