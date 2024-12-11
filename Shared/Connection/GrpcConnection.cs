using Grpc.Net.Client;
using System.Net.Http;
using Grpc.Net.Client.Web;

namespace Shared.Connection
{
    internal class GrpcConnection : IGrpcConnection
    {
        public GrpcChannel Channel { get; private set; }

        public GrpcConnection(string address)
        {
            var options = new GrpcChannelOptions
            {
                HttpHandler = new GrpcWebHandler(new HttpClientHandler())
            };
            Channel = GrpcChannel.ForAddress(address, options);
        }
    }
}
