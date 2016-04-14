using Microsoft.Practices.Unity;

namespace IoCSample00_Simple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<CustomerService>();
            var customerService = unityContainer.Resolve<CustomerService>();
        }
    }
}