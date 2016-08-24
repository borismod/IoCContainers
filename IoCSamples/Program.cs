using Microsoft.Practices.Unity;

namespace IoCSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerDTOMapper, CustomerDtoMapper>();
            container.RegisterType<ICustomerService, CustomerService>();

            var customerService = container.Resolve<ICustomerService>();
        }
    }
}
