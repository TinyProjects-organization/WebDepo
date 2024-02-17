using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class ReceteService
    {
        private readonly DataContext _context;

        public ReceteService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> ReceteOlusturma(List<Recete> recetes)
        {
            try
            {
                await _context.ReceteS.AddRangeAsync(recetes);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = recetes
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
                    ClassName = "ReceteOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumReceteleriGetir()
        {
            try
            {
                var receteler = await _context.ReceteS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = receteler
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
