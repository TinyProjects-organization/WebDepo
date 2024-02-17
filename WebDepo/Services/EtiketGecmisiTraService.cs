using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Data;
using WebDepo.Helper;
namespace WebDepo.Service
{
    public class EtiketGecmisiTraService
    {
        private readonly DataContext _context;

        public EtiketGecmisiTraService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> EtiketGecmisiTraOlusturma(List<EtiketGecmisiTra> etiketGecmisiTras)
            //(IslemTipi islemTipi, long islemYapanKullaniciId, short etiketDepoKodu, double anaEtiketMiktar, string anaEtiket, short olusanDepoKodu, double olusanMiktar, string olusanEtiket, long etiketGecmisiMasId)
        {
            try
            {
                //var etiketGecmisiMas = new EtiketGecmisiTra
                //{
                //    IslemTipi = islemTipi,
                //    OlusturulmaTarihi = DateTime.Now,
                //    OlusturanKullaniciId = islemYapanKullaniciId,
                //    SilindiMi = false,
                //    AnaDepoKodu = etiketDepoKodu,
                //    AnaEtiketMiktari = anaEtiketMiktar,
                //    AnaEtiket = anaEtiket,
                //    OlusanDepoKodu = olusanDepoKodu,
                //    OlusanEtiketMiktari = olusanMiktar,
                //    OlusanEtiket = olusanEtiket,
                //    EtiketGecmisiMasId = etiketGecmisiMasId,
                //};
                await _context.EtiketGecmisiTraS.AddRangeAsync(etiketGecmisiTras);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = etiketGecmisiTras
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
                    ClassName = "EtiketGecmisiTraOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumEtiketGecmisiTra()
        {
            try
            {
                var etiketGecmisiMas = await _context.EtiketGecmisiMasS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = etiketGecmisiMas
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
                    ClassName = "TumEtiketGecmisiTra",
                };
                return returnValue;
            }
        }

    }
}
