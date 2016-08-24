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
        private readonly ILog _logger;
        private readonly Random _random;

        public CustomerService(ILog logger)
        {
            _logger = logger;
            _random = new Random();
        }

        public void AddCustomer()
        {
            Thread.Sleep(_random.Next(1000));
            _logger.Info("Adding customer...");
        }
    }
}