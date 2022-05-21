using Grpc.Core;
using GrpcService;

namespace GrpcServiceQoniac.Services
{
    public class QoniacService : Qoniac.QoniacBase
    {
      
        public QoniacService(ILogger<QoniacService> logger)
        {
          
        }

        public override Task<ConvertReply> CurrencyToWords(ConvertRequest request, ServerCallContext context)
        {
            QoniacBussinesLayer.QoniacTask qoniacTask = new();
            return Task.FromResult(new ConvertReply
            {
                Message = qoniacTask.CurrencyToWords(request.Currency),
            });
        }
    }
}