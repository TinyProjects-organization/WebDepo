using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Data;
using WebDepo.Helper;
namespace WebDepo.Service
{
    public class RafService
    {
        private readonly DataContext _context;

        public RafService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> RafOlusturma(short depoKodu, string alt, string ust, string sag, string sol, string rafKodu, string rafHacmi, double rafAgirligi, long islemYapanKullaniciId, string sirketKodu)
        {
            try
            {
                string rafEtiketi = Guid.NewGuid().ToString();
                var raf = new Raf
                {
                    DepoKodu = depoKodu,
                    Alt = alt,
                    Ust = ust,
                    Sag = sag,
                    Sol = sol,
                    RafEtiket = rafEtiketi,
                    OlusturulmaTarihi = DateTime.Now,
                    OlusturanKullaniciId =  islemYapanKullaniciId,
                    RafKodu = rafKodu,
                    RafHacmi = rafHacmi,
                    MaxRafAgirligi = rafAgirligi,
                    SilindiMi = false,
                    SirketKodu = sirketKodu,
                };

                await _context.RafS.AddAsync(raf);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = raf
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
                    ClassName = "RafOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumRaflariGetir()
        {
            try
            {
                var raflar = await _context.RafS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = raflar
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
                    ClassName = "TumRaflariGetir",
                };
                return returnValue;
            }
        }

    }
}
