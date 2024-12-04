using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dress_rent.entities;
using dress_rent.core.interfaces;

namespace dress_rent.Data.Repository
{
    public class CriticismRepository : IRepository<CriticismEntity>
    {
        readonly DataContext _context;
        public CriticismRepository(DataContext context)
        {
            _context = context;
        }

        public List<CriticismEntity> GetAllData()
        {
            return _context.criticismlist.ToList();
        }
        public bool Add(CriticismEntity c)
        {
            try
            {
                _context.criticismlist.Add(c);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public CriticismEntity GetById(int id)
        {
            return _context.criticismlist.Where(x => x.Id == id).FirstOrDefault();
        }
        public int GetIndexById(int id)
        {
            return _context.criticismlist.ToList().FindIndex(x => x.Id == id);
        }
        public bool Update(CriticismEntity c, int index)
        {
            try
            {
                // עדכון השדות המלאים בלבד על האובייקט ברשימה
                if (c.CustomerId > 0)
                {
                    _context.criticismlist.ToList()[index].CustomerId = c.CustomerId;
                }
                if (c.DressId > 0)
                {
                    _context.criticismlist.ToList()[index].DressId = c.DressId;
                }
                if (c.CriticismDate != default)
                {
                    _context.criticismlist.ToList()[index].CriticismDate = c.CriticismDate;
                }
                if (c.Rating >= 1 && c.Rating <= 5)
                {
                    _context.criticismlist.ToList()[index].Rating = c.Rating;
                }
                if (!string.IsNullOrWhiteSpace(c.Content))
                {
                    _context.criticismlist.ToList()[index].Content = c.Content;
                }
                // נעדכן את Isrecomended ללא בדיקה מיוחדת
                _context.criticismlist.ToList()[index].Isrecomended = c.Isrecomended;

                // שמירת העדכונים
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // טיפול בשגיאה
                Console.WriteLine($"Error updating criticism: {ex.Message}");
                return false;
            }
        }
        public bool Delete(int index)
        {
            _context.criticismlist.ToList().RemoveAt(index);
            return true;
        }
    }
}
