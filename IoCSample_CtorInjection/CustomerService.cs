using System.Runtime.CompilerServices;

namespace IoCSample_CtorInjection
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