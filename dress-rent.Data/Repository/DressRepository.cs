using dress_rent.core.interfaces;
using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.Data.Repository
{
    public class DressRepository: IRepository<DressEntity>
    {
        readonly DataContext _context;
        public DressRepository(DataContext context)
        {
            _context = context;
        }

        public List<DressEntity> GetAllData()
        {
            return _context.dresslist.ToList();
        }
        public bool Add(DressEntity c)
        {
            try
            {
                _context.dresslist.Add(c);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DressEntity GetById(int id)
        {
            return _context.dresslist.Where(x => x.Id == id).FirstOrDefault();
        }
        public int GetIndexById(int id)
        {
            return _context.dresslist.ToList().FindIndex(x => x.Id == id);
        }

        public bool Update(DressEntity d, int index)
        {
            try
            {
      

                if (!string.IsNullOrWhiteSpace(d.Name))
                {
                    _context.dresslist.ToList()[index].Name = d.Name;
                }
                if (d.Size > 0)
                {
                    _context.dresslist.ToList()[index].Size = d.Size;
                }
                if (!string.IsNullOrWhiteSpace(d.Color))
                {
                    _context.dresslist.ToList()[index].Color = d.Color;
                }
                if (!string.IsNullOrWhiteSpace(d.Material))
                {
                    _context.dresslist.ToList()[index].Material = d.Material;
                }
                if (d.Price > 0)
                {
                    _context.dresslist.ToList()[index].Price = d.Price;
                }
                if (d.NumberOfTimesBorrowed >= 0)
                {
                    _context.dresslist.ToList()[index].NumberOfTimesBorrowed = d.NumberOfTimesBorrowed;
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
            _context.dresslist.ToList().RemoveAt(index);
            return true;
        }
    }
}
