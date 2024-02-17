using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;
using WebDepo.Model;
using WebDepo.Service;

namespace WebDepo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MalKabulcontroller
    {

        private readonly DataContext _context;
        private readonly EtiketSevice _etiketSevice;
        private readonly IrsaliyeSiparisEsleme _irsaliyeSiparisEsleme;

        public MalKabulcontroller(DataContext context,EtiketSevice etiketSevice, IrsaliyeSiparisEsleme irsaliyeSiparisEsleme)
        {
            _context = context;
            _etiketSevice = etiketSevice;
            _irsaliyeSiparisEsleme = irsaliyeSiparisEsleme;
        }

        [HttpPost("SipariseIstinadenMalKabul")]
        [SwaggerOperation(Summary = "SipariseIstinadenMalKabul")]
        public async Task<ReturnType> SipariseIstinadenMalKabul(string cariKodu, DateTime irsaliyeTarihi, string irsaliyeNo, List<IrsaliyeSiparisEsleme> irsaliyeSiparisList, List<MalKabul> malKabul)
        {
            try
            {
                //foreach (var item in malKabul)
                //{
                //    _etiketSevice.EtiketOlusturmaIslemi();

                //}
                //_irsaliyeSiparisEsleme.

                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                };
                await _context.SaveChangesAsync();
                return returnValue;
            }
            catch (Exception ex)
            {
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Error,
                    Message = "",
                    ExceptionMessage = ex.Message,
                    ClassName = "SipariseIstinadenMalKabul",
                };
                return returnValue;
            }
        }
    }
}
