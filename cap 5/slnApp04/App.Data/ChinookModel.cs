using App.Entities;
using System.Data.Entity;

namespace App.Data
{
    public class ChinookModel:DbContext
    {
        public ChinookModel() : base("name=cnxChinookDB")
        {
            //inactivando al lazy loading
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Artist> Artist { get; set; }

        public virtual DbSet<Customer> Customer { get; set; }

        public virtual DbSet<Album> Album { get; set; }

    }
}
