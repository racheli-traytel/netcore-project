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
    public class Order_DetailsService: IOrder_DetailsService
    {
        readonly IRepository<Order_DetailsEntity> irepository;

        public Order_DetailsService(IRepository<Order_DetailsEntity> irepository)
        {
            this.irepository = irepository;
        }

        public List<Order_DetailsEntity> GetList() { return irepository.GetAllData(); }
        public Order_DetailsEntity GetById(int id)
        {
            return irepository.GetById(id);
        }
        public bool AddOrder_Details(Order_DetailsEntity c)
        {
            if (irepository.GetById(c.Id) == null)
            {
                return irepository.Add(c);

            }
            return false;
        }
        public bool Update(int id, Order_DetailsEntity c)
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
