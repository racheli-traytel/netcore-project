using dress_rent.core.interfaces;
using dress_rent.core.interfaces.services_interfaces;
using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.Servise
{
    public class OrderService: IOrderService
    {
        readonly IRepository<orderEntity> irepository;

        public OrderService(IRepository<orderEntity> irepository)
        {
            this.irepository = irepository;
        }

        public List<orderEntity> GetList() { return irepository.GetAllData(); }
        public orderEntity GetById(int id)
        {
            return irepository.GetById(id);
        }
        public bool AddOrder(orderEntity c)
        {
            if (irepository.GetById(c.Id) == null)
            {
                return irepository.Add(c);

            }
            return false;
        }
        public bool Update(int id, orderEntity c)
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
            return irepository.Delete(index);

        }
    }
}
