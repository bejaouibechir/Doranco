using MVCCore.Services;

namespace MVCCore.Extensions
{
    static public class ServiceCollectionExtension
    {
        static  public void AddEventLogService(this IServiceCollection servicecollection)
        {
            ServiceDescriptor descriptor = new ServiceDescriptor(typeof(IEventLogService),
                        typeof(EventLogService), ServiceLifetime.Singleton);
            servicecollection.Add(descriptor);
        }
    }
}
