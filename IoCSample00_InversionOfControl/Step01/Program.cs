namespace IoCSample00_InversionOfControl.Step01
{
    static class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Add();
        }
    }

    public class Customer
    {
        private SqlServer dal = new SqlServer();

        bool Validate() { return true; }

        public void Add()
        {
            if (Validate())
            {
                dal.Add(this);
            }
        }
    }

    public class SqlServer
    {
        public void Add(Customer customer)
        {
            
        }
    }
}
