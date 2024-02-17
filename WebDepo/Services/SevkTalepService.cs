using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;


namespace WebDepo.Service
{
    public class SevkTalepService
    {
        private readonly DataContext _context;

        public SevkTalepService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> TumSevkTalepleriGetir()
        {
            try
            {
                var sevkTalepler = await _context.SevkTalepS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = sevkTalepler
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
                    ClassName = "TumSevkTalepleriGetir",
                };
                return returnValue;
            }
        }

    }
}
