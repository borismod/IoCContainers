using System.Runtime.CompilerServices;

namespace IoCSample_CtorInjection
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
        void GetCustomer(int userId);
    }

    public class CustomerRepository : ICustomerRepository
    {
        public void GetCustomer(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}