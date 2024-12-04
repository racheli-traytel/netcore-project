using dress_rent.core.interfaces;
using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.Data.Repository
{
    public class CustomerRepository: IRepository<CustomerEntity>
    {
        readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public List<CustomerEntity> GetAllData()
        {
            return _context.customerlist.ToList();
        }
        public bool Add(CustomerEntity c)
        {
            try
            {
                _context.customerlist.Add(c);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public CustomerEntity GetById(int id)
        {
            return _context.customerlist.Where(x => x.Id == id).FirstOrDefault();
        }
        public int GetIndexById(int id)
        {
            return _context.customerlist.ToList().FindIndex(x => x.Id == id);
        }

        public bool Update(CustomerEntity c, int index)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(c.Name))
                {
                    _context.customerlist.ToList()[index].Name = c.Name;
                }
                if (!string.IsNullOrWhiteSpace(c.Email))
                {
                    _context.customerlist.ToList()[index].Email = c.Email;
                }
                if (!string.IsNullOrWhiteSpace(c.Address))
                {
                    _context.customerlist.ToList()[index].Address = c.Address;
                }
                if (!string.IsNullOrWhiteSpace(c.Phone))
                {
                    _context.customerlist.ToList()[index].Phone = c.Phone;
                }
                if (c.BirthDate != default)
                {
                    _context.customerlist.ToList()[index].BirthDate = c.BirthDate;
                }
                if (c.RegistratinDate != default)
                {
                    _context.customerlist.ToList()[index].RegistratinDate = c.RegistratinDate;
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
            _context.customerlist.ToList().RemoveAt(index);
            return true;
        }

    }
}
