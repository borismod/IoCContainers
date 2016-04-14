using System;

namespace IoCSample05_AutoFacSingleton
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository m_Repository;
        private ICustomerDtoMapper m_Mapper;

        public CustomerService(
            ICustomerRepository repository,
            ICustomerDtoMapper mapper)
        {
            m_Repository = repository;
            m_Mapper = mapper;
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
    }

    public class CustomerRepository : ICustomerRepository
    {
        private Guid m_SessionId;
        public CustomerRepository()
        {
            m_SessionId = Guid.NewGuid();
        }
    }
}