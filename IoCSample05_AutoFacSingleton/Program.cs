using Autofac;

#region Singleton

//             containerBuilder.RegisterType<CustomerRepository>().As<ICustomerRepository>().SingleInstance();

#endregion

namespace IoCSample05_AutoFacSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
                .SingleInstance();
            containerBuilder.RegisterType<CustomerDtoMapper>().As<ICustomerDtoMapper>();
            containerBuilder.RegisterType<CustomerService>().As<ICustomerService>();
            var container = containerBuilder.Build();

            var customerRepository = container.Resolve<ICustomerRepository>();
            var customerService = container.Resolve<ICustomerService>();
        }
    }
}
