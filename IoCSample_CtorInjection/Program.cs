using Microsoft.Practices.Unity;

namespace IoCSample_CtorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ICustomerRepository, CustomerRepository>();
            ioc.RegisterType<ICustomerDTOMapper, CustomerDtoMapper>();
            ioc.RegisterType<ICustomerService, CustomerService>();
            var customerService = ioc.Resolve<CustomerService>();
        }
    }
}
