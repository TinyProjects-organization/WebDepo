using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Data;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class KullaniciSirketEslemeService
    {
        private readonly DataContext _context;

        public KullaniciSirketEslemeService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> KullaniciSirketEslemesiOlusturma(long kullaniciId, long islemYapanKullaniciId, string sirketKodu)
        {
            try
            {
                var kullaniciSirketEsleme = new KullaniciSirketEsleme
                {
                    KullaniciId = kullaniciId,
                    OlusturanKullaniciId = islemYapanKullaniciId,
                    OlusturulmaTarihi = DateTime.Now,
                    SilindiMi = false,
                    SirketKodu = sirketKodu
                };

                await _context.KullaniciSirketEslemeS.AddAsync(kullaniciSirketEsleme);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = kullaniciSirketEsleme
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
                    ClassName = "KullaniciSirketEslemesiOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumKullaniciSirketEslemeleriniGetir()
        {
            try
            {
                var sirketEslemeler = await _context.KullaniciSirketEslemeS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = sirketEslemeler
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
                    ClassName = "TumKullaniciSirketEslemeleriniGetir",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> KullaniciSirketEslemesiniSil(long id, long islemYapanKullaniciId)
        {
            try
            {
                var deleteKullaniciSirket = await _context.DepoTransferMasS.FindAsync(id);
                if (deleteKullaniciSirket == null)
                {
                    throw new Exception("Kayıt bulunamadı.");
                }
                deleteKullaniciSirket.SilindiMi = true;
                deleteKullaniciSirket.SilinmeTarihi = DateTime.Now;
                deleteKullaniciSirket.SilenKullaniciId = islemYapanKullaniciId;

                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = deleteKullaniciSirket
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
                    ClassName = "KullaniciSirketEslemesiniSil",
                };
                return returnValue;
            }
        }

    }
}
