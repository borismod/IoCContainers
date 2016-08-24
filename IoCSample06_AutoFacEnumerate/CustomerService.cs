using System.Collections;
using System.Collections.Generic;

namespace IoCSample06_AutoFacEnumerate
{
    public interface ICustomerService
    {
    }

    public class CustomerService : ICustomerService
    {
        private readonly IList<IMessageHandler> _messageHandlers;

        public CustomerService(IList<IMessageHandler> messageHandlers)
        {
            _messageHandlers = messageHandlers;
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