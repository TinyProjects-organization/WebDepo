using WebDepo.Helper;

namespace WebDepo.Service
{

    public class UretimMasService
    {
        private readonly DataContext _context;

        public UretimMasService(DataContext context)
        {
            _context = context;
        }


        public async Task<ReturnType> TumUretimMasGetir()
        {
            try
            {
                var uretimMasters = await _context.UretimMasS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = uretimMasters
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
                    ClassName = "TumUretimMasGetir",
                };
                return returnValue;
            }
        }

    }
}
