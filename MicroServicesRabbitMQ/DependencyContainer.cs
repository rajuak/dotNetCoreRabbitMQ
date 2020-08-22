using System;

public class Class1
{
	public public Class1()
	{
		public static void RegisterServices(IServiceCollection services)
        {
			//domain bus
			services.AddTransient<IEventBus, RabbitMQBus>();
        }
	}
}
