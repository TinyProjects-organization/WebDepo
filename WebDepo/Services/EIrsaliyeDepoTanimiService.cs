using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Serivce
{
    public class EIrsaliyeDepoTanimiSerivce
    {
        private readonly DataContext _context;

        public EIrsaliyeDepoTanimiSerivce(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> EIrsaliyeDepoTanimiOlusturma(string cariKodu, short cikisDepoKodu, short varisDepoKodu, long islemYapanKullanici, string sirketKodu)
        {
            try
            {
                var eirsaiye = new EIrsaliyeDepoTanimi
                {
                    CariKodu = cariKodu,
                    CikisDepo = cikisDepoKodu,
                    VarisDepo = varisDepoKodu,
                    OlusturanKullaniciId = islemYapanKullanici,
                    OlusturulmaTarihi = DateTime.Now,
                    SirketKodu = sirketKodu
                };
                await _context.EIrsaliyeDepoTanimisS.AddAsync(eirsaiye);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = eirsaiye
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
                    ClassName = "EIrsaliyeDepoTanimiOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumEIrsaliyeDepoTanimi()
        {
            try
            {
                var eIrsaliyeDepoTanimi = await _context.EIrsaliyeDepoTanimisS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = eIrsaliyeDepoTanimi
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
                    ClassName = "TumEIrsaliyeDepoTanimi",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> EIrsaliyeDepoTanimiSil(long id, long islemYapanKullanici)
        {
            try
            {
                var deleteTanim = await _context.EIrsaliyeDepoTanimisS.FindAsync(id);
                if (deleteTanim == null)
                {
                    throw new Exception($"Tanim with ID {id} not found.");
                }

                deleteTanim.SilindiMi = true;
                deleteTanim.SilinmeTarihi = DateTime.Now;
                deleteTanim.SilenKullaniciId = islemYapanKullanici;

                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = deleteTanim
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
                    ClassName = "EIrsaliyeDepoTanimiSil",
                };
                return returnValue;
            }
        }


        public async Task<ReturnType> EIrsaliyeDepoTanimiGuncelle(EIrsaliyeDepoTanimi tanim)
        {
            try
            {
                var updateTanim = await _context.EIrsaliyeDepoTanimisS.FindAsync(tanim.Id);
                if (updateTanim == null)
                {
                    throw new Exception($"{tanim.Id} numaralı Tanim bulunamadı.");
                }
                updateTanim.SirketKodu = tanim.SirketKodu;
                updateTanim.SilindiMi = tanim.SilindiMi;
                updateTanim.OlusturanKullaniciId = tanim.OlusturanKullaniciId;
                updateTanim.CariKodu = tanim.CariKodu;
                updateTanim.CikisDepo = tanim.CikisDepo;
                updateTanim.VarisDepo = tanim.VarisDepo;
                updateTanim.GuncellenmeTarihi = DateTime.Now;
                updateTanim.GuncelleyenKullaniciId = tanim.GuncelleyenKullaniciId;

                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = updateTanim
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
                    ClassName = "EIrsaliyeDepoTanimiGuncelle",
                };
                return returnValue;
            }
        }
    }
}
