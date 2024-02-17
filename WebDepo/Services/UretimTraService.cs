using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class UretimTraService
    {
        private readonly DataContext _context;

        public UretimTraService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> TumUretimTralariGetir()
        {
            try
            {
                var uretimTransactions = await _context.UretimTraS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = uretimTransactions
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
                    ClassName = "TumUretimTralariGetir",
                };
                return returnValue;
            }
        }


    }
}
