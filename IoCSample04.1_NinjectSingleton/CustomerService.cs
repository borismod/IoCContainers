using System;

namespace IoCSample04._1_NinjectSingleton
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository m_Repository;
        private ICustomerDTOMapper m_Mapper;

        public CustomerService(
            ICustomerRepository repository,
            ICustomerDTOMapper mapper)
        {
            m_Repository = repository;
            m_Mapper = mapper;
        }
    }

    public class ICustomerDTOMapper
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
        private readonly Guid m_SessionId;

        public CustomerRepository()
        {
            m_SessionId = Guid.NewGuid();
        }

        public Guid SessionId
        {
            get { return m_SessionId; }
        }
    }
}