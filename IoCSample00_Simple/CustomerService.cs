namespace IoCSample00_Simple
{
    public class CustomerService
    {
        private CustomerRepository m_Repository;
        private CustomerDtoMapper m_Mapper;

        public CustomerService(
            CustomerRepository repository,
            CustomerDtoMapper mapper)
        {
            m_Repository = repository;
            m_Mapper = mapper;
        }
    }

    public class CustomerDtoMapper
    {
    }

    public class CustomerRepository
    {

    }
}