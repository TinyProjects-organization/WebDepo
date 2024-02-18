using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using WebDepo.Helper;


namespace WebDepo.Service
{

    public class MalKabulMasService
    {
        private readonly DataContext _context;

        public MalKabulMasService(DataContext context)
        {
            _context = context;
        }

        #region Mal Kabul

        public async Task<ReturnType> MalKabulOlusturmaIslemi(MalKabulMas malKabulMas)
            //(string etiket,string cariKodu, short depoKodu, int islemYapanKullaniciId, string irsaliyeNo, string sirketKodu)
        {
            try
            {
                //var malKabul = new MalKabulMas
                //{
                //    CariKodu = cariKodu,
                //    NetsiseAtildiMi = false,
                //    OlusturulmaTarihi = DateTime.Now,
                //    OlusturanKullaniciId = islemYapanKullaniciId,
                //    IrsaliyeNo = irsaliyeNo,
                //    SirketKodu = sirketKodu
                //};
                await _context.MalKabulMasS.AddAsync(malKabulMas);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = malKabulMas
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
                var malKabuller = await _context.MalKabulMasS.ToListAsync();
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
                var malKabuller = await _context.MalKabulMasS.FindAsync(id);
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
