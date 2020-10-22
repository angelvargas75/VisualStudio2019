using App.Entities;
using System.Collections.Generic;
using System.Linq;

namespace App.Data
{
    public class ArtistDA
    {
        private ChinookModel _context;

        public ArtistDA()
        {
            _context = new ChinookModel();
        }

        public int Count()
        {
            return _context.Artists.Count();
        }

        public List<Artist> Gets(string filterByName)
        {
            return _context.Artists.Where(item=>item.Name.Contains(filterByName)).ToList();
        }

        public int Insert(Artist entity)
        {
            //Se agrega al contexto de entity framework
            _context.Artists.Add(entity);
            _context.SaveChanges();

            return entity.ArtistId;
        }

        public bool Update(Artist entity)
        {
            //Se agrega al contexto de entity framework
            _context.Artists.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

           var result = _context.SaveChanges();

            return result>0;
        }

        public bool Delete(Artist entity)
        {
            //Se agrega al contexto de entity framework
            _context.Artists.Attach(entity);
            _context.Artists.Remove(entity);

            var result = _context.SaveChanges();

            return result>0;
        }
    }
}
