using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcClient;
namespace QoniacBussinesLayer
{
    public class QonaicGrpcClient
    {
        public string GetCurrencyToWordsFromGrpc(string currency, string grpcAddres)
        {
            var channel = GrpcChannel.ForAddress(grpcAddres);
            var client = new Qoniac.QoniacClient(channel);
            var reply = client.CurrencyToWords(new ConvertRequest { Currency = currency });
            return reply.Message;

        }
    }
}
