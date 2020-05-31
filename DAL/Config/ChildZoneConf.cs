using DAL.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Config
{
    class ChildZoneConf : EntityTypeConfiguration<ChildZone>
    {
        ChildZoneConf()
        {
            this.ToTable ("Child Zone");
        }
    }
}
