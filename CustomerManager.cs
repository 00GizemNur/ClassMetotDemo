using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager

    {
      

        
        public void Add( Customer customer)
        {
            Console.WriteLine(customer.CustomerNumber + " Numaralı Müşteri Eklendi "  );

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.CustomerNumber + " Numaralı Müşteri Silindi ");

        }
     
    }
}
