using System;

namespace Constructors // Bir class'ı new lediğimiz zaman çalışan bloktur.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer costemer1 = new Customer {Id=1, FirstName="Engin", LastName="Demiroğ",City="Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer (2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }
    }


    class Customer
    {
        public Customer()
        {
            Console.WriteLine();
        }
        public Customer(int id,string firstName,string lastName,string city)         //ctor //default constructor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;


        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }   
}
