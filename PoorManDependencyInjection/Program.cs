using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoorManDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerRepository = new CustomerRepository();
            var customerDtoMapper = new CustomerDtoMapper();
            var customerService = new CustomerService(customerRepository, customerDtoMapper);
        }
    }
}
