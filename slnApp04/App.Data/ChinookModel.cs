using App.Entities;
using System.Data.Entity;

namespace App.Data
{
    public class ChinookModel:DbContext
    {
        public ChinookModel() : base("name=cnxChinookDB")
        {

        }

        public virtual DbSet<Artist> Artists { get; set; }

        public virtual DbSet<Customer> Customer { get; set; }

    }
}
