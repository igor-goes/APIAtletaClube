using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseRepository<Entity>
    {
        Entity GetByID(int id);
        IEnumerable<Entity> GetAll();
        void Post(Entity entity);
        void Delete(int id);
        void Update (Entity entity);

    }
}
