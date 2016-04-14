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
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ICustomerRepository, CustomerRepository>(
                new ContainerControlledLifetimeManager());
            var customerRepository = ioc.Resolve<ICustomerRepository>();

            ioc.RegisterType<ICustomerDTOMapper, CustomerDtoMapper>();
            ioc.RegisterType<ICustomerService, CustomerService>();
            var customerService = ioc.Resolve<CustomerService>();
        }
    }
}
