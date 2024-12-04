using dress_rent.core.interfaces;
using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.Data.Repository
{
    public class Order_detailsRepository: IRepository<Order_DetailsEntity>
    {
        readonly DataContext _context;
        public Order_detailsRepository(DataContext context)
        {
            _context = context;
        }

        public List<Order_DetailsEntity> GetAllData()
        {
            return _context.order_detailslist.ToList();
        }
        public bool Add(Order_DetailsEntity c)
        {
            try
            {
                _context.order_detailslist.Add(c);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Order_DetailsEntity GetById(int id)
        {
            return _context.order_detailslist.Where(x => x.Id == id).FirstOrDefault();
        }
        public int GetIndexById(int id)
        {
            return _context.order_detailslist.ToList().FindIndex(x => x.Id == id);
        }
        public bool Update(Order_DetailsEntity o, int index)
        {
            try
            {
    

                if (o.OrderId > 0)
                {
                    _context.order_detailslist.ToList()[index].OrderId = o.OrderId;
                }
                if (o.DressId > 0)
                {
                    _context.order_detailslist.ToList()[index].DressId = o.DressId;
                }

                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int index)
        {
            _context.order_detailslist.ToList().RemoveAt(index);
            return true;
        }
    }
}
