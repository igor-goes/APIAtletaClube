using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : BaseEntity
    {
        protected readonly Context _context;
        public BaseRepository(Context context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var obj = _context.Set<Entity>().Where(x => x.Id == id).FirstOrDefault();
            _context.Set<Entity>().Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Entity> GetAll()
        {
            return _context.Set<Entity>().ToList();
        }

        public Entity GetByID(int id)
        {
            return _context.Set<Entity>().Find(id);
        }

        public void Post(Entity entity)
        {
            _context.Set<Entity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Entity entity)
        {
            _context.Set<Entity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
