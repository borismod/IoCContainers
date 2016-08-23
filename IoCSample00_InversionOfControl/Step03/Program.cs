namespace IoCSample00_InversionOfControl.Step03
{
    static class Program
    {
        static void Main(string[] args)
        {
            IDal localDal;
            if (args[0] == "1")
            {
                localDal = new SqlServer();
            }
            else
            {
                localDal = new OracleServer();
            }
            Customer customer = new Customer(localDal);
            customer.Add();
        }
    }

    public class Customer
    {
        private readonly IDal dal;

        public Customer(IDal dal)
        {
            this.dal = dal;
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

    public class OracleServer : IDal
    {
        public void Add(Customer customer)
        {
            
        }
    }

    public interface IDal
    {
        void Add(Customer customer);
    }

    public class SqlServer : IDal
    {
        public void Add(Customer customer)
        {

        }
    }
}