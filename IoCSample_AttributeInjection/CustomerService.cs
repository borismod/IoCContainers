using Microsoft.Practices.Unity;

namespace IoCSample_AttributeInjection
{
    public class CustomerService : ICustomerService
    {
        // [Dependency]
        public ICustomerRepository Repository { get; set; }

        [Dependency]
        public ICustomerDTOMapper Mapper { get; set; }

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