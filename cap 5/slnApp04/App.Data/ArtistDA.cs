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
            return _context.Artist.Count();
        }


        public Artist Get(int id)    //new method
        {
            return _context.Artist.Find(id);
        }



        public List<Artist> Gets(string filterByName)
        {
            return _context.Artist.Where(item=>item.Name.Contains(filterByName)).ToList();
        }

        public int Insert(Artist entity)
        {
            //Se agrega al contexto de entity framework
            _context.Artist.Add(entity);
            _context.SaveChanges();

            return entity.ArtistId;
        }

        public bool Update(Artist entity)
        {
            //Se agrega al contexto de entity framework
            _context.Artist.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

           var result = _context.SaveChanges();

            return result>0;
        }

        public bool Delete(Artist entity)
        {
            //Se agrega al contexto de entity framework
            _context.Artist.Attach(entity);
            _context.Artist.Remove(entity);

            var result = _context.SaveChanges();

            return result>0;
        }
    }
}
