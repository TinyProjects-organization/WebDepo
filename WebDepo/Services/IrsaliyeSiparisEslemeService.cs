using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class IrsaliyeSiparisEslemService
    {
        private readonly DataContext _context;

        public IrsaliyeSiparisEslemService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> IrsaliyeSiparisEslemesiOlusturma(List<IrsaliyeSiparisEsleme> irsaliyeSiparisEslemes)
        {
            try
            {
                await _context.IrsaliyeSiparisEslemeS.AddRangeAsync(irsaliyeSiparisEslemes);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = irsaliyeSiparisEslemes
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
                    ClassName = "DepoTransferMasOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumIrsaliyeSiparisEsleme()
        {
            try
            {
                var eslemeler = await _context.IrsaliyeSiparisEslemeS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = eslemeler
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
                    ClassName = "TumIrsaliyeSiparisEsleme",
                };
                return returnValue;
            }
        }

    }
}
