using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Service
{
    public class USKService
    {
        private readonly DataContext _context;

        public USKService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> TumUSKleriGetir()
        {
            try
            {
                var usks = await _context.USKS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = usks
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
                    ClassName = "TumUSKleriGetir",
                };
                return returnValue;
            }
        }

    }
}
