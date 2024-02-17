using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class SevkTraService
    {
        private readonly DataContext _context;

        public SevkTraService(DataContext context)
        {
            _context = context;
        }

       
        public async Task<ReturnType> TumSevkTransactionlariGetir()
        {
            try
            {
                var sevkTransactions = await _context.SevkTraS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = sevkTransactions
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
                    ClassName = "TumSevkTransactionlariGetir",
                };
                return returnValue;
            }
        }

    }
}
