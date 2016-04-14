using System;
using System.Collections.Generic;

namespace IoCSample07_AutoFacAssemblyScanning
{
    internal class DoNotRegister : Attribute
    {
    }

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
    
    [DoNotRegister]
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