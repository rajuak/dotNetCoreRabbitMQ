using MicroRabbit.Transfer.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MicroRabbit.Transfer.IoC
{
    public class TransferDependencyContainer
    {
        public static void RegisterTransferDbContext(IServiceCollection services)
        {
            services.AddTransient<TransferDbContext>();
        }
    }
}
