using System;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace SensorSystem.GraphDefinitions.Protos
{
   public class GraphDefinitionService : GraphDefinitions.GraphDefinitionsBase
   {
      private readonly ILogger<GraphDefinitionService> _logger;

      public GraphDefinitionService(ILogger<GraphDefinitionService> logger)
      {
         _logger = logger;
      }

      public override Task<GetResponse> Get(GetRequest request, ServerCallContext context)
      {
         var graphDefinitionItem = new GraphDefinitionItem();
         graphDefinitionItem.Id = Guid.NewGuid().ToString();
         graphDefinitionItem.Type = 3;

         var graphDefinition = new GraphDefinition();
         graphDefinition.Id = Guid.NewGuid().ToString();
         graphDefinition.Name = "Graph number 1";
         graphDefinition.Items.Add(graphDefinitionItem);

         var response = new GetResponse()
         {
            GraphDefnition = graphDefinition
         };

         return Task.FromResult(response);
      }
   }
}
