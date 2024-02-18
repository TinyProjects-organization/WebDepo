using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebDepo.GenelClass
{
    public class MalKabulMasClass
    {
        public long Id { get; set; }

        public string CariKodu { get; set; }

        public string IrsaliyeNo { get; set; }

        public bool NetsiseAtildiMi { get; set; } = false;

        public bool SilindiMi { get; set; } = false;

        public long OlusturanKullaniciId { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public long? GuncelleyenKullaniciId { get; set; }

        public DateTime? GuncellenmeTarihi { get; set; }

        public long? SilenKullaniciId { get; set; }

        public DateTime? SilinmeTarihi { get; set; }

        public string SirketKodu { get; set; }
        public MalKabulTraClass MalKabulTraClass { get; set; }

    }
}
