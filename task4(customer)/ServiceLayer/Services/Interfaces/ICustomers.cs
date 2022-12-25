using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomers
    {
        int GetCustomersAge(Customer[] arr);

        int GetCustomersAges(Customer[] arr);
    }
}
