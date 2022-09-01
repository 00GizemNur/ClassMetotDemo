using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerNumber = 12345678;
            customer1.Name = "Ali";
            customer1.Surname = "ALİ";
            customer1.Contact = "***********";
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerNumber = 87654321;
            customer2.Name = "Veli";
            customer2.Surname = "VELİ";
            customer2.Contact = "***********";
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CustomerNumber = 12345678;
            customer3.Name = "Ayşe";
            customer3.Surname = "AYŞE";
            customer3.Contact = "***********";
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (Customer customer in customers) 

            {
                Console.WriteLine(customer.CustomerNumber);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Contact);
                Console.WriteLine("--------------------");

            }
          
           CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer3);  
            customerManager.Delete(customer2);
           
           


        }
    }
}
