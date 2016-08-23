using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace IoCSample_CtorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.LoadConfiguration();

            container.RegisterType<ICustomerRepository, CustomerRepository>();

            container.RegisterType<ICustomerDTOMapper, CustomerDtoMapper>();
            container.RegisterType<ICustomerService, CustomerService>();

            var customerService = container.Resolve<CustomerService>();



        }
    }
}
