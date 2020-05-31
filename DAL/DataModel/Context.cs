
using DAL.EntitiesDTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace DAL.DataModel
{
    public class Context : DbContext
    {

        public Context()
            : base("name=Zones")
        {
        }

        public DbSet<ChildZone> ZonesList { get; set; }

    }
}