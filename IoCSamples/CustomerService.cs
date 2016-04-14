using Microsoft.Practices.Unity;

namespace IoCSamples
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository m_Repository;
        private ICustomerDTOMapper m_Mapper;

        [InjectionMethod]
        public void Initialize(
            ICustomerRepository repository,
            [Dependency]ICustomerDTOMapper mapper)
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
    }

    public class CustomerRepository : ICustomerRepository
    {

    }
}