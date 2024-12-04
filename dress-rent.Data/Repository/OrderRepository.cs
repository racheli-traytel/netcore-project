using dress_rent.entities;
using dress_rent.core.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dress_rent.Data.Repository
{
    public class OrderRepository : IRepository<orderEntity>
    {
        readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public List<orderEntity> GetAllData()
        {
            return _context.orderlist.ToList();
        }
        public bool Add(orderEntity c)
        {
            try
            {
                _context.orderlist.Add(c);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public orderEntity GetById(int id)
        {
            return _context.orderlist.Where(x => x.Id == id).FirstOrDefault();
        }
        public int GetIndexById(int id)
        {
            return _context.orderlist.ToList().FindIndex(x => x.Id == id);
        }
        public bool Update(orderEntity o, int index)
        {
            try
            {

                if (o.CustomerId > 0)
                {
                    _context.orderlist.ToList()[index].CustomerId = o.CustomerId;
                }
                if (o.OrderDate != default)
                {
                    _context.orderlist.ToList()[index].OrderDate = o.OrderDate;
                }
                if (o.RentDate != default)
                {
                    _context.orderlist.ToList()[index].RentDate = o.RentDate;
                }
                if (o.ReturnDate != default)
                {
                    _context.orderlist.ToList()[index].ReturnDate = o.ReturnDate;
                }
                _context.orderlist.ToList()[index].Status = o.Status;

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
            _context.orderlist.ToList().RemoveAt(index);
            return true;
        }


    }
}
