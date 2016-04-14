using log4net;

namespace IoCSample_AutoFacModule
{
    public interface ICustomerService
    {
        void AddCustomer();
    }

    public class CustomerService : ICustomerService
    {
        private readonly ILog m_Logger;

        public CustomerService(ILog logger)
        {
            m_Logger = logger;
        }

        public void AddCustomer()
        {
            m_Logger.Info("Adding customer...");
        }
    }
}