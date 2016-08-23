using Microsoft.Practices.Unity;

#region singleton

//            ioc.RegisterType<ICustomerRepository, CustomerRepository>(new ContainerControlledLifetimeManager());

#endregion

namespace IoCSample_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<ICustomerRepository, CustomerRepository>(
                new ContainerControlledLifetimeManager());

            var customerRepository = container.Resolve<ICustomerRepository>();

            container.RegisterType<ICustomerDTOMapper, CustomerDtoMapper>();
            container.RegisterType<ICustomerService, CustomerService>();
            var customerService = container.Resolve<CustomerService>();
        }
    }
}
