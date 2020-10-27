using App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class CustomerDA
    {
        private ChinookModel _context2;

        public CustomerDA()
        {
            _context2 = new ChinookModel();
        }

        public int Count()
        {
            return _context2.Customer.Count();
        }

        public List<Customer> Gets(string filterByName)
        {
            return _context2.Customer.Where(item => item.FirstName.Contains(filterByName)).ToList();
        }

        public int Insert(Customer entity)
        {
            //Se agrega al contexto de entity framework
            _context2.Customer.Add(entity);
            _context2.SaveChanges();

            return entity.CustomerId;
        }

        public bool Update(Customer entity)
        {
            //Se agrega al contexto de entity framework
            _context2.Customer.Attach(entity);
            _context2.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            var result = _context2.SaveChanges();

            return result > 0;
        }

        public bool Delete(Customer entity)
        {
            //Se agrega al contexto de entity framework
            _context2.Customer.Attach(entity);
            _context2.Customer.Remove(entity);

            var result = _context2.SaveChanges();

            return result > 0;
        }
    }
}
