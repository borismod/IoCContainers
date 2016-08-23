using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDependencyInjection
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
