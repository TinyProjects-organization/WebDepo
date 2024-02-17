using WebDepo.Helper;

namespace WebDepo.Service
{
    public class UskTuketimService
    {
        private readonly DataContext _context;

        public UskTuketimService(DataContext context)
        {
            _context = context;
        }



        public async Task<ReturnType> TumUSKTuketimleriniGetir()
        {
            try
            {
                var uskTuketimler = await _context.UskTuketimS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = uskTuketimler
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
                    ClassName = "TumUSKTuketimleriniGetir",
                };
                return returnValue;
            }
        }

    }
}
