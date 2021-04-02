using KahveSirketleriSimülasyon.Abstract;
using KahveSirketleriSimülasyon.Concrete;
using KahveSirketleriSimülasyon.Entities;
using KahveSirketleriSimülasyon.Adapters;
using System;

namespace KahveSirketleriSimülasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1986, 1, 6), FirstName = "Engin", LastName = "Demiroğ" ,NatioanlityId = "28861499108"});
            Console.WriteLine();
        }
    }
}
