using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient6;

// Add Http Client Handler // gRPC channel option
//var httpHandler = new HttpClientHandler();
//httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

//using var channel = GrpcChannel.ForAddress("https://localhost:8585");
//using var channel = GrpcChannel.ForAddress($"http://localhost:8585", new GrpcChannelOptions() { HttpHandler = httpHandler });

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress($"https://mygrpcgreeterapp.azurewebsites.net/");

var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "Jeff" });

Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();













////////// UNARY CALL ////////// [starts with the client sending a request message.  A response message is returned when the service finishes]

//using var channel = GrpcChannel.ForAddress($"https://grpcgreeteryarp5.azurewebsites.net/", new GrpcChannelOptions() { HttpHandler = httpHandler });
////using var channel = GrpcChannel.ForAddress($"http://localhost:8583", new GrpcChannelOptions() { HttpHandler = httpHandler });
//var client = new Greeter.GreeterClient(channel);
//var reply = await client.SayHelloAsync(
//                  new HelloRequest { Name = "Jeff" });

//Console.WriteLine("Greeting: " + reply.Message);
//Console.WriteLine("Press any key to exit...");
//Console.ReadKey();