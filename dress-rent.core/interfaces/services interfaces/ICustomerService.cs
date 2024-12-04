using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.core.interfaces.services_interfaces
{
    public interface ICustomerService
    {
        List<CustomerEntity> GetList();
        CustomerEntity GetById(int id);

        bool AddCustomer(CustomerEntity c);

        bool Update(int id, CustomerEntity c);

        bool Remove(int id);
      
    }
}
