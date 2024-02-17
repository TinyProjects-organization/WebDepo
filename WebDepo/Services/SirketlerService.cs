using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Service
{
    public class SirketlerService
    {
        private readonly DataContext _context;

        public SirketlerService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> TumSirketleriGetir()
        {
            try
            {
                var sirketler = await _context.SirketlerS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = sirketler
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
                    ClassName = "TumSirketleriGetir",
                };
                return returnValue;
            }
        }

    }
}
