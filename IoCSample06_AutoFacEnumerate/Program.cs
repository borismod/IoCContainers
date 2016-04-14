using Autofac;

#region Enumeration

//containerBuilder.RegisterType<MessageHandler1>().AsImplementedInterfaces();
//containerBuilder.RegisterType<MessageHandler2>().AsImplementedInterfaces();
//containerBuilder.RegisterType<MessageHandler3>().AsImplementedInterfaces();
//containerBuilder.RegisterType<CustomerService>().AsImplementedInterfaces();

#endregion

namespace IoCSample06_AutoFacEnumerate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            var container = containerBuilder.Build();

            var customerService = container.Resolve<ICustomerService>();
        }
    }
}