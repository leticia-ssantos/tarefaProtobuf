using Grpc.Core;
using Server;
using Shared.Protos;

namespace Server.Services
{
    public class GreeterService : Shared.Protos.Greeter.GreeterBase
    {
        //private readonly ILogger<GreeterService> _logger;
        //public GreeterService(ILogger<GreeterService> logger)
        //{
        //    _logger = logger;
        //}

        public override Task<Shared.Protos.HelloReply> SayHello(Shared.Protos.HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Shared.Protos.HelloReply
            {
                Message = "Hello World" + request.Text
                
            });
        }

        public override Task<Shared.Protos.TimeReply> GetTime(Shared.Protos.TimeRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Shared.Protos.TimeReply
            {
                Hour = request.Hour,
                Minute = request.Minute,
                Second = request.Second,
            });
        }
    }
}
