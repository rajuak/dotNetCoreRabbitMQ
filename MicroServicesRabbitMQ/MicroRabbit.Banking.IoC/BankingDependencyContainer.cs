using MicroRabbit.Banking.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.IoC
{
    public class BankingDependencyContainer
    {
        public static void RegisterBankingDbContext(IServiceCollection services)
        {
            services.AddTransient<BankingDbContext>();
        }
    }
}
