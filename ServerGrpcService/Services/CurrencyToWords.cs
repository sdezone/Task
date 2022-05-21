using Grpc.Core;
using ServerGrpcService;

namespace ServerGrpcService.Services
{
    public class QoniacService : Qoniac.QoniacBase
    {
        private readonly ILogger<CurrencyToWordsRequest> _logger;
        public QoniacService(ILogger<QoniacService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}