using Grpc.Net.Client;
using SensorSystem.GraphDefinitions.Protos;
using System;
using System.Threading.Tasks;
using static SensorSystem.GraphDefinitions.Protos.GraphDefinitions;

namespace GraphDefinitionServiceClient
{
   class Program
   {
      static async Task Main(string[] args)
      {
         using var channel = GrpcChannel.ForAddress("http://localhost:5001");
         var client = new GraphDefinitionsClient(channel);
         var reply = await client.GetAsync(new GetRequest());
      }
   }
}