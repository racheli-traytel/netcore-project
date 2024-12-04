using dress_rent.core.interfaces;
using dress_rent.core.interfaces.services_interfaces;
using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dress_rent.Servise
{
    public class CustomerService: ICustomerService
    {
        readonly IRepository<CustomerEntity> irepository;
    

        public CustomerService(IRepository<CustomerEntity> irepository)
        {
            this.irepository = irepository;
        }

        public List<CustomerEntity> GetList() { return irepository.GetAllData(); }
        public CustomerEntity GetById(int id)
        {
            return irepository.GetById(id);
        }
        public bool AddCustomer(CustomerEntity c)
        {
            if(irepository.GetById(c.Id) == null)
            {
               return irepository.Add(c);
            }
            return false;
        }
        public bool Update(int id, CustomerEntity c)
        {
            if (irepository.GetById(id) == null)
            {
                return false;
            }
            int i = irepository.GetIndexById(id);
            return irepository.Update(c, i);
        }
        public bool Remove(int id)
        {
            int index = irepository.GetIndexById(id);
            if (index < 0) return false;
          return  irepository.Delete(index);

        }
    }
}
