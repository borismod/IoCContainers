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
            var containerBuilder = new ContainerBuilder();
            
            containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t=>!t.GetCustomAttributes<DoNotRegister>().Any())
                   .AsImplementedInterfaces();
            
            var container = containerBuilder.Build();

            var customerService = container.Resolve<ICustomerService>();
        }
    }
}
