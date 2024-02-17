using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Service
{

    public class OnayliDatDepoTanimlamaService
    {
        private readonly DataContext _context;

        public OnayliDatDepoTanimlamaService(DataContext context)
        {
            _context = context;
        }

        

        public async Task<ReturnType> TumOnayliDepoTanimlamalariGetir()
        {
            try
            {
                var depoTanimlamalar = await _context.OnayliDatDepoTanimlamaS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = depoTanimlamalar
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
                    ClassName = "TumDepoTanimlamalariGetir",
                };
                return returnValue;
            }
        }

    }
}
