using Grpc.Core;

using Shared.Protos;

namespace Server.Services
{
    public class GreeterService : Shared.Protos.Greeter.GreeterBase
    {
        public override Task<Shared.Protos.HelloReply> SayHello(Shared.Protos.HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Shared.Protos.HelloReply
            {
                Message = "Seja bem vindo(a) " + request.Text + "!"
                
            });
        }

        public override Task<Shared.Protos.TimeReply> GetTime(Shared.Protos.TimeRequest request, ServerCallContext context)
        {
            DateTime now = DateTime.Now;

            return Task.FromResult(new Shared.Protos.TimeReply
            {
                Hour = (uint)now.Hour, 
                Minute = (uint)now.Minute,
                Second = (uint)now.Second,
            });
        }

        public override Task<Resp> GetHalf(Req request, ServerCallContext context)
        {
            return Task.FromResult(new Shared.Protos.Resp
            {
                Number = request.Number / 2,
            });
        }

    }
}
