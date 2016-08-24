using System;
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

            //container.RegisterType<ICustomerRepository, CustomerRepository>(
            //    new ContainerControlledLifetimeManager());

            container.RegisterType<ICustomerRepository, CustomerRepository>();

            container.RegisterType<ICustomerDTOMapper, CustomerDtoMapper>();
            container.RegisterType<ICustomerService, CustomerService>();
            var customerService = container.Resolve<ICustomerService>();

            var firstRepository = container.Resolve<ICustomerRepository>();
            var secondRepository = container.Resolve<ICustomerRepository>();

            Console.WriteLine(firstRepository.SessionId);

            Console.WriteLine(secondRepository.SessionId);

            Console.ReadKey();

        }
    }
}
