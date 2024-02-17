using WebDepo.Helper;

namespace WebDepo.Service
{
    public class UretimTalepService
    {
        private readonly DataContext _context;

        public UretimTalepService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> TumUretimTalepleriniGetir()
        {
            try
            {
                var uretimTalepler = await _context.UretimTalepS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = uretimTalepler
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
                    ClassName = "TumUretimTalepleriniGetir",
                };
                return returnValue;
            }
        }


    }
}
