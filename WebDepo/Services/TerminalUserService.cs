using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Service
{
    public class TerminalUserService
    {
        private readonly DataContext _context;

        public TerminalUserService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> TumTerminalUserlariGetir()
        {
            try
            {
                var terminalUsers = await _context.TerminalUserS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = terminalUsers
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
                    ClassName = "TumTerminalUserlariGetir",
                };
                return returnValue;
            }
        }


    }
}
