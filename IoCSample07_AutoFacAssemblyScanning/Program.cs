using System.Linq;
using System.Reflection;
using Autofac;

#region DoNotRegister

//                     .Where(t=>!t.GetCustomAttributes<DoNotRegister>().Any())

#endregion

namespace IoCSample07_AutoFacAssemblyScanning
{

    class Program
    {
        static void Main(string[] args)
        {
            RegisterAll();
        }

        private static void RegisterAll()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();

            var container = containerBuilder.Build();

            var customerService = container.Resolve<ICustomerService>();
        }
        private static void RegisterExcept()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => !t.GetCustomAttributes<DoNotRegister>().Any())
                .AsImplementedInterfaces();

            var container = containerBuilder.Build();

            var customerService = container.Resolve<ICustomerService>();
        }
    }
}
