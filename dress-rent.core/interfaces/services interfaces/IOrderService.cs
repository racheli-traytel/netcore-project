using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.core.interfaces.services_interfaces
{
    public interface IOrderService
    {
        List<orderEntity> GetList();
        orderEntity GetById(int id);

        bool AddOrder(orderEntity c);

        bool Update(int id, orderEntity c);

        bool Remove(int id);
       
    }
}
