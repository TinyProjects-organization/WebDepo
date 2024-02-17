using System.Linq;
using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Service
{
    public class EtiketSevice
    {
        private readonly DataContext _context;

        public EtiketSevice(DataContext context)
        {
            _context = context;

        }

        #region Etiket
        public async Task<ReturnType> EtiketOlusturmaIslemi(string stokKodu, short depoKodu, int islemYapanKullaniciId, double miktar, string malKabulEtiketi, short gkk, string rafEtiketi, DateTime skt, string sirketKodu, string partiNo)
        {
            try
            {
                string olusturulmusBarkod = Guid.NewGuid().ToString();
                var barkod = new Etiket
                {
                    EtiketNo = olusturulmusBarkod,
                    DepodaMi = true,
                    OlusturanKullaniciId = islemYapanKullaniciId,
                    OlusturulmaTarihi = DateTime.Now,
                    DepoKodu = depoKodu,
                    MalKabulEtiketi = String.IsNullOrEmpty(malKabulEtiketi) ? olusturulmusBarkod : malKabulEtiketi,
                    Gkk = gkk,
                    Miktar = miktar,
                    RafEtiketi = rafEtiketi,
                    StokKodu = stokKodu,
                    Skt = skt,
                    SirketKodu = sirketKodu,
                    PartiNo = partiNo,
                    silindiMi = false,
                };
                await _context.BarkodS.AddAsync(barkod);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = barkod
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "EtiketOlusturmaIslemi",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumBarkodlariGetir()
        {
            try
            {
                var barkodlar = await _context.BarkodS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = barkodlar
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "TumBarkodlariGetir",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> BarkodGetir(string etiket)
        {
            try
            {
                var barkod = await _context.BarkodS.Where(x => x.EtiketNo == etiket && x.silindiMi == false).ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = barkod
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "BarkodGetir",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> BarkodSil(string etiket, long islemYapanKullanici)
        {
            try
            {
                Etiket deleteBarkod = await _context.BarkodS.Where(x => x.EtiketNo == etiket).FirstOrDefaultAsync() ?? new Etiket();
                deleteBarkod.silindiMi = true;
                deleteBarkod.SilinmeTarihi = DateTime.Now;
                deleteBarkod.SilenKullaniciId = islemYapanKullanici;
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = deleteBarkod
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "BarkodGetir",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> BarkodGuncelle(Etiket barkod)
        {
            try
            {
                var updateBarkod = await _context.BarkodS.Where(x => x.EtiketNo == barkod.EtiketNo && x.silindiMi == false).ToListAsync();
                if (updateBarkod == null)
                {
                    throw new Exception(" Güncellenecek etiket bulunamadı.");
                }
                _context.Entry(updateBarkod).CurrentValues.SetValues(barkod);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "BarkodGuncelle",
                };
                return returnValue;
            }
        }
        #endregion

        #region Koli

        public async Task<ReturnType> KolilemeIslemi(List<Etiket> barkod)
        {
            try
            {
                string koliBarkodu = Guid.NewGuid().ToString();
                var barkodEtiketleri = barkod.Select(x => x.EtiketNo).ToList();
                var updateBarkod = await _context.BarkodS.Where(x => barkodEtiketleri.Contains(x.EtiketNo) && !x.silindiMi).ToListAsync();
                if (updateBarkod == null)
                {
                    throw new Exception(" Güncellenecek etiket bulunamadı.");
                }
                updateBarkod.ForEach(b => b.KoliEtiketi = koliBarkodu);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = updateBarkod
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "KolilemeIslemi",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> KoliBoz(string koliEtiketi)
        {
            try
            {
                var updateBarkod = await _context.BarkodS.Where(x => x.KoliEtiketi == koliEtiketi && !x.silindiMi).ToListAsync();
                if (updateBarkod == null)
                {
                    throw new Exception(" Güncellenecek etiket bulunamadı.");
                }
                updateBarkod.ForEach(b => b.KoliEtiketi = null);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = updateBarkod
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "KoliBoz",
                };
                return returnValue;
            }
        }

        #endregion

        #region Palet
        public async Task<ReturnType> PaletlemeIslemi(List<Etiket> barkod)
        {
            try
            {
                string paletBarkodu = Guid.NewGuid().ToString();
                var barkodEtiketleri = barkod.Select(x => x.EtiketNo).ToList();
                var updateBarkod = await _context.BarkodS.Where(x => barkodEtiketleri.Contains(x.EtiketNo) && !x.silindiMi).ToListAsync();
                if (updateBarkod == null)
                {
                    throw new Exception(" Güncellenecek etiket bulunamadı.");
                }
                updateBarkod.ForEach(b => b.PaletEtiketi = paletBarkodu);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = updateBarkod
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "PaletlemeIslemi",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> PaletBoz(string paletEtiketi)
        {
            try
            {
                var updateBarkod = await _context.BarkodS.Where(x => x.PaletEtiketi == paletEtiketi && !x.silindiMi).ToListAsync();
                if (updateBarkod == null)
                {
                    throw new Exception(" Güncellenecek etiket bulunamadı.");
                }
                updateBarkod.ForEach(b => b.PaletEtiketi = null);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = updateBarkod
                };
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "PaletBoz",
                };
                return returnValue;
            }
        }

        #endregion

    }
}
