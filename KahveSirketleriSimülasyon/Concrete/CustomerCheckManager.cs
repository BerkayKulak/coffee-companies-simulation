using KahveSirketleriSimülasyon.Abstract;
using KahveSirketleriSimülasyon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KahveSirketleriSimülasyon.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
