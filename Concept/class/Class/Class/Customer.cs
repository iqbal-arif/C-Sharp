partial class Program
{
    /*
     *
     *Overload Method Signature
    public class Customer
    {
        public Customer() { }
        public Customer(string name) { }

        public Customer (int id, string name) { }
    }
     */

    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id; 
        }

        public Customer(int id, string name)
            : this(id)
        {
            //this.Id=id;
            this.Name = name;
        }

        

    }
}