using System.Reflection;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Castle.DynamicProxy;

namespace IoCSample09_Interception
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            
            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces()
                .EnableInterfaceInterceptors();

            containerBuilder.RegisterType<LoggingInterceptor>().Named<IInterceptor>("LoggingInterceptor");

            var container = containerBuilder.Build();

            var customerService = container.Resolve<ICustomerService>();
            for (int i = 1000 - 1; i >= 0; i--)
            {
                customerService.AddCustomer();
            }
        }
    }
}
