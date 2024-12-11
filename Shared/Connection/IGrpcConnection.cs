using Grpc.Net.Client;

namespace Shared.Connection
{
    public interface IGrpcConnection
    {
        GrpcChannel Channel { get; }
    }
}
