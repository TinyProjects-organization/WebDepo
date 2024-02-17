using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Service
{
    public class DepoTransferMasService
    {
        private readonly DataContext _context;

        public DepoTransferMasService(DataContext context)
        {
            _context = context;

        }
        public async Task<ReturnType> DepoTransferMasOlusturma(string belgeSeri, string cariKodu, short cikisDepoKodu, short varisDepoKodu, bool eirsaliyeMi, bool isEmriTamamlandiMi, string siparisNo, string uretimIsEmriNo, string sirketKodu)
        {
            try
            {
                var depoTransferMasBilgi = new DepoTransferMas
                {
                    BelgeSeri = belgeSeri,
                    OlusturulmaTarihi = DateTime.Now,
                    CariKodu = cariKodu,
                    CikisDepo = cikisDepoKodu,
                    VarisDepo = varisDepoKodu,
                    EIrsaliyeMi = eirsaliyeMi,
                    IsEmriTamamlandiMi = isEmriTamamlandiMi,
                    NetsiseAtildiMi = false,
                    SilindiMi = false,
                    SiparisNo = siparisNo,
                    UretimIsEmriNo = uretimIsEmriNo,
                    SirketKodu = sirketKodu
                };

                await _context.DepoTransferMasS.AddAsync(depoTransferMasBilgi);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = depoTransferMasBilgi
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
                    ClassName = "DepoTransferMasOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumDepoTransferMas()
        {
            try
            {
                var depoTransferMas = await _context.DepoTransferMasS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = depoTransferMas
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
                    ClassName = "TumDepoTransferMas",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> DepoTransferMasSilById(long id, long islemYapanKullanici)
        {
            try
            {
                var deleteMaster = await _context.DepoTransferMasS.FindAsync(id);
                if (deleteMaster == null)
                {
                    throw new Exception("Kayıt bulunamadı.");
                }
                deleteMaster.SilindiMi = true;
                deleteMaster.SilinmeTarihi = DateTime.Now;
                deleteMaster.SilenKullaniciId = islemYapanKullanici;
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = deleteMaster
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
                    ClassName = "DepoTransferMasSil",
                };
                return returnValue;
            }
        }
    }
}
