using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMena
{
    class CustomerManager
    {
        public void AddCumstomer(Customer customer)
        {
            Console.WriteLine(" New customer is name :" + customer.Name);
            Console.WriteLine(" New customer is surname :" + customer.Surname);
            Console.WriteLine(" New customer is Id :" + customer.Id);
            Console.WriteLine(" New customer is password :" + customer.Password);
            Console.WriteLine(" New customer is balance :" + customer.Balance + "TL\n");
        }

        public void ListCumstomer(Customer customer)
        {

            Console.WriteLine(" Names of customers listed :" + customer.Name);
            Console.WriteLine(" Surnames of customers listed :" + customer.Surname);
            Console.WriteLine(" Id of customers listed :" + customer.Id);
            Console.WriteLine(" The password of listed customers :" + customer.Password);
            Console.WriteLine(" Balance of customers listed :" + customer.Balance + "TL\n");

        }
        public void DeleteCumstomer(Customer customer)
        {
            Console.WriteLine(" Delete customer is name :" + customer.Name);
            Console.WriteLine(" Delete customer is surname :" + customer.Surname);
            Console.WriteLine(" Delete customer is Id :" + customer.Id);
            Console.WriteLine(" Delete customer is password :" + customer.Password);
            Console.WriteLine(" Delete customer is balance :" + customer.Balance + "TL\n");

        }
    }
}
