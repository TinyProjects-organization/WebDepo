using Microsoft.AspNetCore.Mvc;
using WebDepo.Model;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Data;
using WebDepo.Helper;

namespace WebDepo.Service
{
    public class DepoTransferTraService
    {
        private readonly DataContext _context;

        public DepoTransferTraService(DataContext context)
        {
            _context = context;
        }

        public async Task<ReturnType> DepoTransferTraOlusturma(List<DepoTransferTra> depoTransferTras)
        {
            try
            {
                await _context.DepoTransferTraS.AddRangeAsync(depoTransferTras);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = depoTransferTras
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
                    ClassName = "DepoTransferTraOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumDepoTransferTra()
        {
            try
            {
                var depoTransferTras = await _context.DepoTransferTraS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = depoTransferTras
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
                    ClassName = "TumDepoTransferTra",
                };
                return returnValue;
            }
        }



    }
}
