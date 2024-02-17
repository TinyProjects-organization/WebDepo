using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebDepo.Helper;
using WebDepo.Model;

namespace WebDepo.Serivce
{
    public class DepoTransferTalepSerivce
    {
        private readonly DataContext _context;

        public DepoTransferTalepSerivce(DataContext context)
        {
            _context = context;
        }


        public async Task<ReturnType> depoTransferTalepOlusturma(List<DepoTransferTalep> depoTransferTaleps)
        {
            try
            {
                await _context.DepoTransferTalepS.AddRangeAsync(depoTransferTaleps);
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = depoTransferTaleps
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
                    ClassName = "depoTransferTalepOlusturma",
                };
                return returnValue;
            }
        }

        public async Task<ReturnType> TumDepoTransferTalepGetir()
        {
            try
            {
                var talepler = await _context.DepoTransferTalepS.ToListAsync();
                ReturnType returnValue = new ReturnType
                {
                    Status = StatusCode.Success,
                    Data = talepler
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
                    ClassName = "TumDepoTransferTalepGetir",
                };
                return returnValue;
            }
        }


    }
}
