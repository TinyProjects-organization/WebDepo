using WebDepo.Helper;

namespace WebDepo.Service
{
    public class UserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> TumUserleriGetir()
        {
            try
            {
                var users = await _context.UserS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = users
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
                    ClassName = "TumUserleriGetir",
                };
                return returnValue;
            }
        }

    }
}
