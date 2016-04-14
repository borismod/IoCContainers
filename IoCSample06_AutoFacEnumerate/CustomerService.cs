using System.Collections;
using System.Collections.Generic;

namespace IoCSample06_AutoFacEnumerate
{
    public interface ICustomerService
    {
    }

    public class CustomerService : ICustomerService
    {
        private readonly IList<IMessageHandler> m_MessageHandlers;

        public CustomerService(IList<IMessageHandler> messageHandlers)
        {
            m_MessageHandlers = messageHandlers;
        }
    }

    public interface IMessageHandler
    {
         
    }

    public class MessageHandler1 : IMessageHandler
    {
    }

    public class MessageHandler2 : IMessageHandler
    {
    }

    public class MessageHandler3 : IMessageHandler
    {
    }
}