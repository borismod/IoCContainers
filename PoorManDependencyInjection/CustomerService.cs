using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDependencyInjection
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

    public interface ICustomerDtoMapper
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
