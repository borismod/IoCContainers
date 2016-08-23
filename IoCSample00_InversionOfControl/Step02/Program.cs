namespace IoCSample00_InversionOfControl.Step02
{
    static class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);
            customer.Add();
        }
    }

    public class Customer
    {
        private readonly IDal dal;

        public Customer(int dalType)
        {
            if (dalType == 1)
            {
                dal = new SqlServer();
            }
            else
            {
                dal = new OracleServer();
            }
        }

        bool Validate() { return true; }

        public void Add()
        {
            if (Validate())
            {
                dal.Add(this);
            }
        }
    }

    public interface IDal
    {
        void Add(Customer customer);
    }

    public class OracleServer : IDal
    {
        public void Add(Customer customer) { }
    }

    public class SqlServer : IDal
    {
        public void Add(Customer customer) { }
    }
}