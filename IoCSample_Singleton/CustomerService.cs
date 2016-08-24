using System;

namespace IoCSample_Singleton
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repository;
        private ICustomerDTOMapper _mapper;

        public CustomerService(
            ICustomerRepository repository,
            ICustomerDTOMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

    public interface ICustomerDTOMapper
    {
    }

    public class CustomerDtoMapper : ICustomerDTOMapper
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
        private Guid _sessionId;

        public CustomerRepository()
        {
            _sessionId = Guid.NewGuid();
        }

        public Guid SessionId
        {
            get { return _sessionId; }
        }
    }
}