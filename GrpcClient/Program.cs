
using Grpc.Net.Client;
using GrpcClient;

using var channel = GrpcChannel.ForAddress("http://localhost:5136");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
    new HelloRequest { Name = "GreeterClient"}
    );
    
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key");
Console.ReadKey();