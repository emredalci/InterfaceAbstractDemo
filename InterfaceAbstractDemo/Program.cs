using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using InterfaceAbstractDemo.Adabters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdabters());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1995,4,13), FirstName="Emre",LastName="Dalcı",NationalityId="123456798" });
            Console.ReadLine();
        }
    }
}
