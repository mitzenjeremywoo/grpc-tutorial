// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcGreeterClient;

Console.WriteLine("Hello, World!");

var channel = GrpcChannel.ForAddress("https://localhost:7294");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "World" });
Console.WriteLine(reply.Message);


