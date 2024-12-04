using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.core.interfaces.services_interfaces
{
    public interface ICriticismService
    {
        List<CriticismEntity> GetList();
        CriticismEntity GetById(int id);

        bool AddCriticism(CriticismEntity criticism);

        bool Update(int id, CriticismEntity criticism);

        bool Remove(int id);
   
    }
}
