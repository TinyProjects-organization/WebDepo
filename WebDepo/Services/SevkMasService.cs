using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class SevkMaService
    {
        private readonly DataContext _context;

        public SevkMaService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> SevkMasOlusturma(string belgeSeri, string cariKodu, short cikisDepoKodu, short varisDepoKodu, bool eirsaliyeMi, bool isEmriTamamlandiMi, string siparisNo, string uretimIsEmriNo, string sirketKodu)
        {
            try
            {
                var sevkMas = new SevkMas
                {
                    BelgeSeri = belgeSeri,
                    OlusturulmaTarihi = DateTime.Now,
                    CariKodu = cariKodu,
                    CikisDepo = cikisDepoKodu,
                    IsEmriTamamlandiMi = isEmriTamamlandiMi,
                    NetsiseAtildiMi = false,
                    SilindiMi = false,
                    SirketKodu = sirketKodu
                };

                await _context.SevkMasS.AddAsync(sevkMas);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = sevkMas
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
                    ClassName = "SevkMasOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumSevkMas()
        {
            try
            {
                var sevkMasters = await _context.SevkMasS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = sevkMasters
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
                    ClassName = "TumSevkMas",
                };
                return returnValue;
            }
        }

    }
}
