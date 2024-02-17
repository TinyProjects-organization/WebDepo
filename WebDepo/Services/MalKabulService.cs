using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using WebDepo.Helper;


namespace WebDepo.Service
{

    public class MalKabulService
    {
        private readonly DataContext _context;

        public MalKabulService(DataContext context)
        {
            _context = context;
        }

        #region Mal Kabul

        public async Task<ReturnType> MalKabulOlusturmaIslemi(string etiket,string cariKodu, short depoKodu, int islemYapanKullaniciId, string irsaliyeNo, string sirketKodu)
        {
            try
            {
                var malKabul = new MalKabul
                {
                    CariKodu = cariKodu,
                    DepoKodu = depoKodu,
                    NetsiseAtildiMi = false,
                    Etiket = etiket,
                    OlusturulmaTarihi = DateTime.Now,
                    OlusturanKullaniciId = islemYapanKullaniciId,
                    IrsaliyeNo = irsaliyeNo,
                    SirketKodu = sirketKodu
                };
                await _context.MalKabulS.AddAsync(malKabul);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = malKabul
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
                    ClassName = "MalKabulOlusturmaIslemi",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumMalKabulleriGetir()
        {
            try
            {
                var malKabuller = await _context.MalKabulS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = malKabuller
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
                    ClassName = "TumMalKabulleriGetir",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> MalKabulGetirById(int id)
        {
            try
            {
                var malKabuller = await _context.MalKabulS.FindAsync(id);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = malKabuller
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
                    ClassName = "MalKabulGetir",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> MalKabulSil(long id, long islemYapanKullaniciId)
        {
            try
            {
                var deleteMalKabul = await _context.BarkodS.FindAsync(id);
                deleteMalKabul.silindiMi = true;
                deleteMalKabul.SilinmeTarihi = DateTime.Now;
                deleteMalKabul.SilenKullaniciId = islemYapanKullaniciId;
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = deleteMalKabul
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
                    ClassName = "MalKabulSil",
                };
                return returnValue;
            }
        }

        #endregion

    }
}
