using System.Reflection;
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
            containerBuilder.RegisterType<CustomerService>().As<ICustomerService>();
            containerBuilder.RegisterType<MessageHandler1>().As<IMessageHandler>();
            containerBuilder.RegisterType<MessageHandler2>().As<IMessageHandler>();
            containerBuilder.RegisterType<MessageHandler3>().As<IMessageHandler>();
            var container = containerBuilder.Build();

            var customerService = container.Resolve<ICustomerService>();
        }
    }
}