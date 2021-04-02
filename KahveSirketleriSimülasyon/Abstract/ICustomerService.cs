using KahveSirketleriSimülasyon.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace KahveSirketleriSimülasyon.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
