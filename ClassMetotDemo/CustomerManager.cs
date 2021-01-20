using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Congratilations! Adding " + customer.Name +" "+customer.Surname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Delete customer : " + customer.Name + " " + customer.Surname);
        }
        public void List(Customer c)
        {
            Console.WriteLine("List customer : " + c.Name +" "+c.Surname+" "+c.PhoneNumber+" "+c.Email);
        }
    }
}
