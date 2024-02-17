using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Services
{
    public class EtiketGecmisiMasService
    {
        private readonly DataContext _context;

        public EtiketGecmisiMasService(DataContext context)
        {
            _context = context;
        }
        public async Task<ReturnType> EtiketGecmisiMasOlusturma(IslemTipi islemTipi, long islemYapanKullaniciId, string sirketKodu, long islemId)
        {
            try
            {
                var etiketGecmisiMas = new EtiketGecmisiMas
                {
                    IslemTipi = islemTipi,
                    OlusturulmaTarihi = DateTime.Now,
                    OlusturanKullaniciId = islemYapanKullaniciId,
                    SilindiMi = false,
                    SirketKodu = sirketKodu,
                    YapilanIsleminId = islemId
                };
                await _context.EtiketGecmisiMasS.AddRangeAsync(etiketGecmisiMas);
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
