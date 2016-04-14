using System.Reflection;
using Autofac;

#region Scanning

//containerBuilder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
//containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

#endregion

namespace IoCSample_AutoFacModule
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            //containerBuilder.RegisterModule<LoggingModule>();
            containerBuilder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            containerBuilder.RegisterType<CustomerService>().AsImplementedInterfaces();

            var container = containerBuilder.Build();

            var customerService = container.Resolve<ICustomerService>();
            customerService.AddCustomer();

        }
    }
}