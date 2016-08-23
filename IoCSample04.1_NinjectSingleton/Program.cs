using System;
using Ninject;

namespace IoCSample04._1_NinjectSingleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<ICustomerRepository>().To<CustomerRepository>().InSingletonScope();
            // kernel.Bind<ICustomerRepository>().To<CustomerRepository>();

            var customerRepositoryFirst = kernel.Get<ICustomerRepository>();

            Console.WriteLine(customerRepositoryFirst.SessionId);

            var customerRepositorySecond = kernel.Get<ICustomerRepository>();

            Console.WriteLine(customerRepositorySecond.SessionId);

            Console.ReadKey();
        }
    }
}