using MicroRabbit.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Rabbit.Infra.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
   public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus,RabbitMQBus>
        }
    }
}
