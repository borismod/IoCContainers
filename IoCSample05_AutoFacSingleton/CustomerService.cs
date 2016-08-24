using System;

namespace IoCSample05_AutoFacSingleton
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repository;
        private ICustomerDtoMapper _mapper;

        public CustomerService(
            ICustomerRepository repository,
            ICustomerDtoMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

    public class ICustomerDtoMapper
    {
    }

    public class CustomerDtoMapper : ICustomerDtoMapper
    {
    }

    public interface ICustomerService
    {
    }

    public interface ICustomerRepository
    {
        Guid SessionId { get; }
    }

    public class CustomerRepository : ICustomerRepository
    {
        private readonly Guid sessionId;
        public CustomerRepository()
        {
            sessionId = Guid.NewGuid();
        }

        public Guid SessionId
        {
            get { return sessionId; }
        }
    }
}