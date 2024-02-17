using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class TerminalService
    {
        private readonly DataContext _context;

        public TerminalService(DataContext context)
        {
            _context = context;
        }

        

        public async Task<ReturnType> TumTerminalleriGetir()
        {
            try
            {
                var terminals = await _context.TerminalS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = terminals
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
                    ClassName = "TumTerminalleriGetir",
                };
                return returnValue;
            }
        }

    }
}
