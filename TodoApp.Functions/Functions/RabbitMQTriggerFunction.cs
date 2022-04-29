using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client.Events;
using System.Text;

namespace com.tmc.functions
{
    public class RabbitMQTriggerFunction
  {
    [FunctionName("RabbitMQTriggerCSharp")]
    public static void RabbitMQTrigger_BasicDeliverEventArgs(
        [RabbitMQTrigger("externally_configured_queue", ConnectionStringSetting = "RabbitMQConnectionString")] BasicDeliverEventArgs args,
        ILogger logger
        )
    {
      logger.LogInformation($"C# RabbitMQ queue trigger function processed message: {Encoding.UTF8.GetString(args.Body)}");
      throw new System.Exception("Something");
    }
  }
}