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
                if (data == null)
                {
                    throw new ArgumentNullException(nameof(data), "Input data is null.");
                }

                string jsonData = data.ToString();

                if (string.IsNullOrWhiteSpace(jsonData))
                {
                    throw new ArgumentException("Input data is empty or whitespace.", nameof(data));
                }
                MalKabulMasClass malKabulList = JsonConvert.DeserializeObject<MalKabulMasClass>(jsonData);

                ReturnType malKabulInsert = _malKabulMasService.MalKabulOlusturmaIslemi(malKabulList);
                if (!Helper.Helper.ReturnValueControl(malKabulInsert))
                {

                }

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
