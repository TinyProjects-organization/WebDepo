using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.GenelClass;
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
        private readonly MalKabulMasService _malKabulMasService;

        public MalKabulcontroller(DataContext context, EtiketSevice etiketSevice, IrsaliyeSiparisEsleme irsaliyeSiparisEsleme, MalKabulMasService malKabulMasService)
        {
            _context = context;
            _etiketSevice = etiketSevice;
            _irsaliyeSiparisEsleme = irsaliyeSiparisEsleme;
            _malKabulMasService = malKabulMasService;
        }

        [HttpPost("SipariseIstinadenMalKabul")]
        [SwaggerOperation(Summary = "SipariseIstinadenMalKabul")]
        public async Task<ReturnType> SipariseIstinadenMalKabul(object data)
        {
             try
            {
                if (data is null || string.IsNullOrWhiteSpace(data?.ToString()))
                {
                    throw new ArgumentException("Input data is null or empty.", nameof(data));
                }
                MalKabulMasClass malKabulList = JsonConvert.DeserializeObject<MalKabulMasClass>(data?.ToString());
                
                MalKabulMas malKaulMas = new MalKabulMas();
                ReturnType malKabulInsert = await _malKabulMasService.MalKabulOlusturmaIslemi(malKaulMas);
                if (Helper.Helper.ReturnValueControl(malKabulInsert))
                {
                    throw new Exception(malKabulInsert.ExceptionMessage);
                }

                //ReturnType etiketInsert = await _etiketSevice.EtiketOlusturmaIslemi() 

                await _context.SaveChangesAsync().ConfigureAwait(false);
                return new ReturnType
                {
                    Status = StatusCode.Success,
                };
            }
            catch (Exception ex)
            {
                return new ReturnType
                {
                    Status = StatusCode.Error,
                    ExceptionMessage = ex.Message,
                    ClassName = "SipariseIstinadenMalKabul",
                };
            }
        }

    }
}
