using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[4];
            customers[0]= new Customer(1, "a", "a");
            customers[1] = new Customer(2, "b", "b");
            customers[2] = new Customer(3, "c", "c");
            customers[3] = new Customer(1, "A", "A");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ID + " " + customer.Name +" "+ customer.Address); 
            }

            Array.Sort(customers);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ID + " " + customer.Name + " " + customer.Address);
            }

            Console.WriteLine(customers[0].Equals(customers[1]));
            Console.WriteLine(customers[0].CompareTo(customers[1]));

            customers[0] = new Customer(3, "a", "a");
            customers[1] = new Customer(2, "b", "b");
            customers[3] = new Customer(1, "c", "c");
            customers[2] = new Customer(4, "d", "d");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ID + " " + customer.Name + " " + customer.Address);
            }

            AnotherCustomerComparer acc= new AnotherCustomerComparer();
            Array.Sort(customers,acc);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ID + " " + customer.Name + " " + customer.Address);
            }
        }
    }
}
