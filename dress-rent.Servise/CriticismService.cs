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
    public class CriticismService : ICriticismService
    {
        readonly IRepository<CriticismEntity> irepository;

        public CriticismService(IRepository<CriticismEntity> irepository)
        {
            this.irepository = irepository;
        }

        public List<CriticismEntity> GetList() { return irepository.GetAllData(); }
        public CriticismEntity GetById(int id)
        {
            return irepository.GetById(id);
        }
        public bool AddCriticism(CriticismEntity criticism)
        {
            if (irepository.GetById(criticism.Id) == null)
            {
                return irepository.Add(criticism);
            }
            return false;
        }
        public bool Update(int id, CriticismEntity criticism)
        {

            int i = irepository.GetIndexById(id);
            if (i < 0)
                return false;
            return
                irepository.Update(criticism, i);

        }
        public bool Remove(int id)
        {
            int index = irepository.GetIndexById(id);
            if (index < 0) return false;
            return irepository.Delete(index);

        }
    }
}
