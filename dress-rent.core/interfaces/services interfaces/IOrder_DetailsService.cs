using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.core.interfaces.services_interfaces
{
    public interface IOrder_DetailsService
    {

        List<Order_DetailsEntity> GetList();
        Order_DetailsEntity GetById(int id);

        bool AddOrder_Details(Order_DetailsEntity c);


        bool Update(int id, Order_DetailsEntity c);

        bool Remove(int id);
      
      
    }
}
