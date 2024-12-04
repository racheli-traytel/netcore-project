using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.core.interfaces
{
    public interface IRepository<T>
    {

        List<T> GetAllData();

        bool Add(T c);
        T GetById(int id);

        int GetIndexById(int id);

        bool Update(T c, int index);

        bool Delete(int index);
    }
}
