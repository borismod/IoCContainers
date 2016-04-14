using System;
using System.Threading;
using Autofac.Extras.DynamicProxy2;
using log4net;

namespace IoCSample09_Interception
{
    [Intercept("LoggingInterceptor")]
    public interface ICustomerService
    {
        void AddCustomer();
    }

    public class CustomerService : ICustomerService
    {
        private readonly ILog m_Logger;
        private readonly Random m_Random;

        public CustomerService(ILog logger)
        {
            m_Logger = logger;
            m_Random = new Random();
        }

        public void AddCustomer()
        {
            Thread.Sleep(m_Random.Next(1000));
            m_Logger.Info("Adding customer...");
        }
    }
}