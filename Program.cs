using ClassMena;
using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------WALCOME TO ATM---------------\n");


            Customer customer1 = new Customer();
            customer1.Name = "Anna";
            customer1.Surname = "Drawn";
            customer1.Id = 1234567890123456;
            customer1.Password = 12345;
            customer1.Balance = 3500;

            Customer customer2 = new Customer();
            customer2.Name = "Isaac";
            customer2.Surname = "Red";
            customer2.Id = 1234578923446758;
            customer2.Password = 13579;
            customer2.Balance = 7000;

            Customer customer3 = new Customer();
            customer3.Name = "Allison";
            customer3.Surname = "Mark";
            customer3.Id = 123567239012321;
            customer3.Password = 87653;
            customer3.Balance = 1000;

            CustomerManager customerManager = new CustomerManager();

            //adding
            customerManager.AddCumstomer(customer1);
            customerManager.AddCumstomer(customer2);
            customerManager.AddCumstomer(customer3);

            //list
            customerManager.ListCumstomer(customer1);
            customerManager.ListCumstomer(customer2);
            customerManager.ListCumstomer(customer3);

            //delete
            customerManager.DeleteCumstomer(customer1);
            customerManager.DeleteCumstomer(customer2);
            customerManager.DeleteCumstomer(customer3);
        }
    }
}
