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
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<CustomerService>().As<ICustomerService>();
            containerBuilder.RegisterType<MessageHandler1>().As<IMessageHandler>();
            containerBuilder.RegisterType<MessageHandler2>().As<IMessageHandler>();
            containerBuilder.RegisterType<MessageHandler3>().As<IMessageHandler>();
            IContainer container = containerBuilder.Build();

            ICustomerService customerService = container.Resolve<ICustomerService>();
        }
    }
}