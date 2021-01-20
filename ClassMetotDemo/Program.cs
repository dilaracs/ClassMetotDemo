using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "demir";
            customer1.Surname = "kara";
            customer1.PhoneNumber = "5389655874";
            customer1.Email = "demir@gmail.com";

            Customer customer2 = new Customer();
            customer2.Name = "doruk";
            customer2.Surname = "kara";
            customer2.PhoneNumber = "5369855874";
            customer2.Email = "doruk@gmail.com";

            Customer customer3 = new Customer();
            customer3.Name = "azra";
            customer3.Surname = "ac";
            customer3.PhoneNumber = "5356987412";
            customer3.Email = "azra@gmail.com";

            Customer[] customers = new Customer[]
            {
                customer1,
                customer2,
                customer3
            };
            foreach (Customer customer in customers)
            {
                //Console.WriteLine(customer.Name + "\n" + customer.Surname + "\n" + customer.PhoneNumber + "\n" +customer.Email + "\n-----");
            }
            Console.WriteLine("Add Customer");
            CustomerManager customermanager = new CustomerManager();
            foreach (var customer in customers)
            {
                customermanager.Add(customer);

            }
            Console.WriteLine(" ");
            Console.WriteLine("List All Customers");
            foreach (var c in customers)
            {
                customermanager.List(c);

            }
            Console.WriteLine(" ");
            Console.WriteLine("Delete Customer3");

            customermanager.Delete(customer3);

            
           // Console.WriteLine("");
        }
    }
    
}