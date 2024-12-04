using dress_rent.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dress_rent.core.interfaces.services_interfaces
{
    public interface IDressService
    {
        bool AddDress(DressEntity c);

        bool Update(int id, DressEntity c);

        bool Remove(int id);
        List<DressEntity> GetList();
        DressEntity GetById(int id);
        
    

    }
}
