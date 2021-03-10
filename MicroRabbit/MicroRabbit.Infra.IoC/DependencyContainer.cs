using MicroRabbit.Banking.Applicatrion.Interfaces;
using MicroRabbit.Banking.Applicatrion.Services;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Rabbit.Infra.Bus;
using MIcrosoft.Banking.Data.Context;
using MIcrosoft.Banking.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
   public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
         
            services.AddTransient<BankingDbContext>();
        }
    }
}
