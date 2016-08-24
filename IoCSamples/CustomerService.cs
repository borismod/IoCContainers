using Microsoft.Practices.Unity;

namespace IoCSamples
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repository;
        private ICustomerDTOMapper _mapper;

        [InjectionMethod]
        public void Initialize(
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
    }

    public class CustomerRepository : ICustomerRepository
    {

    }
}